## Welcome to CSHRPBSCS

1. [Hello World](#item_1)
2. [Hello World using a Method](#item_2)
3. [Hello World using a Class](#item_3)
4. [Object Oriented Programming Concepts](#item_4)
    1. [Abstraction](#item_4a)
    2. [Encapsulation](#item_4b)
    3. [Polymorphism](#item_4c)
    4. [Inheritance](#item_4d)

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

### <a id="item_4"></a>4. Object Oriented Programming Concepts
### <a id="item_4a"></a>4a. Abstraction

Abstraction is a concept of hiding the unneccessary functions from the user and showing what is needed only. In order to accomplish abstraction, encapsulation must be implemented.

Sources: 
[Short explanation of abstraction](https://www.youtube.com/watch?v=L1-zCdrx8Lk)
[Abstraction vs. Encapsulation](https://www.youtube.com/watch?v=1Q4I63-hKcY&t=676s)

### <a id="item_4b"></a>4b. Encapsulation

Encapsulation is hiding or exposing your properties, fields, methods, and etc. using access modifiers.
As a rule, public properties are favored over public fields.

```csharp
    public class VendingMachine
    {
        private decimal basePrice; //'Hiding' the Field using private access modifier
        
        public decimal BasePrice; //Making the Property public so that it can be accessed by the Main class
        {
            get { return basePrice; }
            set { basePrice = value; }
        }
    }
```

### <a id="item_4b"></a>4c. Inheritance

```csharp
    public class VendingMachine
    {
        private decimal basePrice;
        public decimal BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }
    }

    //Inheritance
    //Inheriting VendingMachine class
    public class NewVendingMachine : VendingMachine
    {
    }
```

Main Program
```csharp
 class Program
    {
        static void Main(string[] args)
        {
            NewVendingMachine myNewMachine = new NewVendingMachine();
            myNewMachine.BasePrice = 20;
            //Accessing BasePrice Property through Inheritance
            Console.WriteLine("[Inheritance] Price: " + myNewMachine.BasePrice);
            Console.ReadLine();
        }
    }
```

### <a id="item_4b"></a>4d. Polymorphism

```csharp
    public class VendingMachine
    {
        private decimal basePrice;

        public decimal BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }

        public virtual void GetSelectedDrink() //add VIRTUAL modifier so that it can be overridden
        {
            Console.WriteLine("[Base Class] Getting the drink.");
        }
    }

    //Inheritance
    public class NewVendingMachine : VendingMachine
    {
        //Polymorphism
        public override void GetSelectedDrink() //overide the method
        {
            Console.WriteLine("[Polymorphed] Getting the NEW drink.");
        }
    }
```

Main Program

```csharp
    class Program
    {
        static void Main(string[] args)
        {
            NewVendingMachine myNewMachine = new NewVendingMachine();
            myNewMachine.GetSelectedDrink(); //OUTPUT: [Polymorphed] Getting the NEW drink.
            Console.ReadLine();
        }
    }
```

