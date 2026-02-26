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


        }
    }
}
