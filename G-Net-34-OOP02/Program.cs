using G_Net_34_OOP02.Classes;
using System;

namespace G_Net_34_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            #region a
            //Identify at least two problems with this design from an encapsulation perspective?
            //1)public double balance ->Correct :private double _balance and And then set the property that you want.
            //[Prevents invalid state].
            //2)public string Owner ->Correct :private string _owner and And then set the property that you want.
            //[Prevents invalid state].
            #endregion
            #region b
            //I created a class called Qb and wrote the correct method in it
            //Qb qb = new Qb();
            //qb.Owner = "John Doe";
            //qb.Balance = 1000;
            //qb.Withdraw(200);
            //Console.WriteLine($"Balance = {qb.Balance}");
            #endregion
            #region c
            //Explain why exposing fields directly (as public) is considered a bad practice in OOP?
            /*1) It breaks encapsulation:
             *Exposing fields directly allows external code to access and modify the internal state of an object without any control or validation.
             *This can lead to unintended consequences and make it difficult to maintain the integrity of the object's state.
            */
            //Summary: Encapsulation maintains: 
            //1- Prevents invalid state .
            //2- Forces rule-based changes .
            //3- Allows future modification.
            #endregion
            #endregion
            #region Q02
            /*
             *  What is the difference between a field and a property in C#? Can a property contain logic? 
             *  1)Filed : A field is a variable that is declared directly in a class or struct and is used to store data. Fields can be public, private, protected, or internal, and they can be of any data type. They are accessed directly by their name.
             *  Direct data storage .
             *  No validation .
             *  Breaks encapsulation
             *  2)Property : A property is a member of a class that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can contain logic in their get and set accessors, allowing for validation, transformation, or other operations when getting or setting the value. They are accessed like fields but are actually methods under the hood.
             *  Controlled access.
             *  Can validate .
             *  Enforces encapsulation
             */
            //Give an example of a read-only property that returns a calculated value.?
            //this Example in class Rectangle
            //Rectangle r01= new Rectangle();
            //r01.Length = 5;
            //r01.Width = 3;
            //Console.WriteLine($"The area = {r01.Length} * {r01.Width}= {r01.Area}");
            ////r01.Area = 100; Invaild
            #endregion
            #region Q03
            #region a
            //What is `this[int index]` called? Explain its purpose.?
            //this[int index] is called an indexer in C#. An indexer allows an object to be indexed like an array, providing a way to access elements of a collection or class using array-like syntax. The purpose of an indexer is to enable the use of square brackets [] to access elements within a class or struct, making it more intuitive and convenient for users of the class to work with collections of data.
            #endregion
            #region b
            //What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?
            //Throw an exception because the index is out of range. To make the indexer safer, you can add validation to check if the index is within the valid range before allowing access or modification. For example:
            //Example of safer indexer : Look to class StudentRegister
            //StudentRegister S01=new StudentRegister();
            //S01[0] = "Ali";
            //S01[1] = "Sara";
            //S01[2] = "Kareem";
            //S01[3] = "Rawan";
            //S01[4] = "Eman";
            //S01[5] = "Faten";//This will not be added because the index is out of range.
            //Console.WriteLine(S01[0]);
            //Console.WriteLine(S01[1]);
            //Console.WriteLine(S01[2]);
            //Console.WriteLine(S01[3]);
            //Console.WriteLine(S01[4]);
            //Console.WriteLine(S01[5]);//This will return "Not in range" because the index is out of range.

            #endregion
            #region c
            ////Can a class have more than one indexer? If yes, give an example of when that would be useful?
            ////Yes , a class can have more than one indexer .This Overloading allows you to provide different ways to access the data (parameters) .
            ////Example : go to Class Library
            //Libaray l01 = new Libaray("Alex Libaray");
            //l01.AddBook(new Book("123-957-456", "C# Basic"));
            //l01.AddBook(new Book("123-959-456", "C# Advandes"));
            //l01.AddBook(new Book("123-951-451", "C# OOP"));
            //l01.AddBook(new Book("153-900-156", "Network2"));
            //Console.WriteLine("___________With Indexer__________");
            //Console.WriteLine($"Indexer [0] = {l01[0]}");
            //Console.WriteLine($"Indexer [3] = {l01[3]}");
            //Console.WriteLine($"Indexer [7] Invaild = {l01[7]}");
            //Console.WriteLine("___________With ISBN__________");
            //Console.WriteLine($"Indexer  = {l01["153-900-156"]}");
            //Console.WriteLine($"Indexer  = {l01["123-959-456"]}");
            //Console.WriteLine($"Indexer  Invaild = {l01["123-111-456"]}");
            #endregion
            #endregion
            #region Q04
            #region a
            //What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?
            //The static keyword means that TotalOrders belongs to the class itself rather than any specific object (instance). All objects share the same single copy of this variable.
            //Different :
            //TotalOrders is shared across all orders (global to the class), while Item is an instance field, meaning every individual order has its own unique item name
            #endregion
            #region b
            //Can a static method inside `Order` access the `Item` field directly? Why or why not?
            /*No, it cannot.
             * Reason: A static method exists at the class level and does not have access to this (a specific object). 
             * Since Item depends on a specific instance of the class, 
             * the static method wouldn't know which order's Item to access
             */
            #endregion
            #endregion

        }
    }
}
