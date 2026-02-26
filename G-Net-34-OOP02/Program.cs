using G_Net_34_OOP02.Classes;

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



        }
    }
}
