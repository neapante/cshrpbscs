## Welcome to CSHRPBSCS

1. [Hello World](#item_1)
2. [Hello World using a Method](#item_2)
3. [Hello World using a Class](#item_3)

### <a id="item_1"></a>1. Hello World

```c#
using System;

namespace HelloWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world.");
            Console.ReadLine();
        }
    }
}
```

### <a id="item_2"></a>2. Hello World using a Method

```c#
using System;

namespace HelloWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello(); //Method call
            Console.ReadLine();
        }

        //Method declaration
        public static void SayHello()
        {
            Console.WriteLine("Hello world.");
        }
    }
}
```
### <a id="item_3"></a>3. Hello World using a Class

First, create a class in Visual Studio (right click > add > class).
The name of the class is SaySomething (SaySomething.cs).
Content of the SaySomething Class.
```c#
using System;

namespace HelloWorlds
{
    class SaySomething
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }
    }
}
```
The Main Program
```csharp
using System;

namespace HelloWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            SaySomething hello = new SaySomething(); //create an object
            hello.SayHello(); //call the method in the class to say Hello!
            Console.ReadLine();
        }
    }
}
```

