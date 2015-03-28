# Project Nova

## Naming conversions

### For C# code

References
- [Capitalization Conventions](https://msdn.microsoft.com/en-us/library/ms229043.aspx)
- [C# Coding Conventions (C# Programming Guide)](https://msdn.microsoft.com/en-us/library/ff926074.aspx)

```
using System;
using System.Threading.Tasks;

//For namespaces, use Pascal casing.

namespace NamingConversions
{
    // For classes, enums, use Pascal casing.
    public class SampleClass
    {
        //For constanrs, use Pascal casing.
        public const int Count = 0;

        //For static menbers, use Pascal casing.
        //For public fields, use Pascak casing.
        public static string Name = "Nova";
        //For private fieldss, use camel case with an unserscore.

        //For properties, use Pascal casing.
        public string StatusData { get; set; }
        //For methods, use Pascal casing.
        //For parameters, use camel casing.
        public void MyMethod(int myParameter)
        {
        }

        //For asynchronous methods, use Pascal casing with subfix "Async".
        public async Task ProcessAsync()
        {
        }

        //For events, use Pascal casing.
        public event EventHandler MyEvent;
    }

    //For interfaces, use Pascal casing with prefix "I".
    public interface ISample
    {
    }
}
```
### For Typescript