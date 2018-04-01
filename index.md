## Welcome to CSHRPBSCS

1. [Hello World](#item_1)
2. [Hello World using a Method](#item_2)
3. [Hello World using a Class](#item_3)
4. [Object Oriented Programming Concepts](#item_4)
    1. [Abstraction](#item_4a)
    2. [Encapsulation](#item_4b)
    3. [Polymorphism](#item_4c)
    4. [Inheritance](#item_4d)
5. [Constructors and Deconstructors](#item_5)
6. [Array and ArrayList](#item_6)

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
    //To inherit a class add ':' then the Base Class
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
        //overide the method with OVERRIDE
        public override void GetSelectedDrink() 
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

### <a id="item_5"></a>5. Constructors and Deconstructors

```csharp
class Program
    {
        static void Main(string[] args)
        {
            Cow c = new Cow("Barney");
            Console.ReadLine();
        }
    }

    class Cow
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Constructor
        //Shoul be the same name as the Class
        //A constructor that writes the name of the cow
        public Cow (string cowName)
        {
            Name = cowName;
            Console.WriteLine(Name);
        }

        //Destructor
        //Same as the Class but should have the tilde sign before it
        //Runs when the class is not reachable - https://www.dotnetperls.com/destructor
        ~Cow()
        {
            Console.WriteLine("Running Destructor");
        }
    }
```

### <a id="item_5"></a>6. Array and ArrayList

```csharp
class Program
    {
        static void Main(string[] args)
        {
            //Array
            //Has a fixed length and only int data type can be added 
            int[] array1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);

            //ArrayList
            //Does not need the size to be indicated and it grows dynamically as a value added in the array list
            //Any datatype can be added
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add(1.23);
            arrayList1.Add("String");

            Console.WriteLine(arrayList1[0]);
            Console.WriteLine(arrayList1[1]);
            Console.WriteLine(arrayList1[2]);
            Console.ReadLine();
        }
    }
```
