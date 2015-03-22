using System;

namespace Nova.Test.Data
{
    public class TestData
    {
        public TestData()
        {
            
        }

        public TestData(int id,string name,int age)
        {
            Id= id;
            Name = name;
            Age = age;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}