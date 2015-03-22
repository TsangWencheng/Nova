using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.ConfigurationModel;
using MongoDB.Driver;
using Nova.Data;
using Xunit;

namespace Nova.Test.Data
{
    public class MongoDbDataWarehouseTest : IDisposable
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly string _databaseName;
        private readonly IDataWarehouse _warehouse;
        private List<TestData> _testData;

        public MongoDbDataWarehouseTest()
        {
            var config = new Configuration().AddJsonFile("Config.json");
            var connectionString = config.Get("Data:MongoDb:Server");
            _client = new MongoClient(connectionString);
            _databaseName = config.Get("Data:MongoDb:DataBase");
            _database = _client.GetDatabase(_databaseName);
            _warehouse = new MongoDbDataWarehouse();
        }

        public async void Dispose()
        {
            await _client.DropDatabaseAsync(_databaseName);
        }

        //Should return an empty IQueryable is db is empty.
        [Theory]
        public async void ShouldBeEmptyQueryableIfEmptyDb()
        {
            var data = await _warehouse.QueryAsync<TestData>();
            Assert.NotNull(data);
            Assert.IsType<IQueryable<TestData>>(data);
            Assert.False(data.Any());
        }

        //Data should be in the database after saved.
        [Fact]
        public async void ShouldBeInDbAfterSaved()
        {
            var data = new TestData(1, "Mongo", 18);
            await _warehouse.SaveAsync(data);
            var found = await GetCollection<TestData>().FindAsync(td => td.Id == data.Id);
            Assert.NotNull(found);
        }

        //Should get data if data in in the db.
        [Fact]
        public async void ShouldGetDataIfInDb()
        {
            await FillDbAsync();
            var data = await _warehouse.QueryAsync<TestData>();
            Assert.True(GetTestData().All(td => data.Count(d => d.Id == td.Id) == 1));
        }

        private IMongoCollection<T> GetCollection<T>()
        {
            return _database.GetCollection<T>(typeof(T).Name);
        }

        private async Task FillDbAsync()
        {
            var data = GetTestData();
            var collection = GetCollection<TestData>();
            await collection.InsertManyAsync(data);
        }

        private List<TestData> GetTestData()
        {
            return _testData ?? (_testData = new List<TestData>(new[]
            {
                new TestData(1, "hello", 15),
                new TestData(2, "hi", 16),
                new TestData(3, "bye", 17)
            }));
        }
    }
}