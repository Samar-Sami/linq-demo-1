using static System.Runtime.InteropServices.JavaScript.JSType;

namespace linq_demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Extension Method
            //string x = "12345";
            //string y = "ahmed";
            ////first way to call extention method:
            ////Console.WriteLine(x.IsNumeric()); if u write "this" before str 

            ////second way to call extension method
            //bool flag = StringExtensionMethods.IsNumeric(x);
            //Console.WriteLine(flag);
            #endregion
            #region what is linq
            // language integrated query
            //unified syntax
            // +40 Extension methods => interface : IEnumerable
            // linq operators => 13 category
            // works with any DB or data stored in sequence
            //local sequence L20, L2XML
            //Remote sequence => L2EF
            #endregion
            #region Linq syntax
            //List <int> numbers = new List<int>() {1,5,4,7,8,9,3 };
            ////fluent syntax
            //var oddNumbers = numbers.Where(x => x % 2 == 1);

            //foreach (int number in oddNumbers)
            //    Console.WriteLine(number);
            ////query syntax
            ///// queries like sql
            ///// start with "from"
            ///// then variable range , for example x that represents each element in the sequence 
            ///// end with select or group by
            /////
            /////
            //Console.WriteLine("second");
            //var oddNumbers2 = from x in numbers
            //                  where x % 2 == 1
            //                  select x;
            //foreach (int number in oddNumbers2)
            //    Console.WriteLine(number);







            #endregion
            #region linq execution ways
            //// differed execution
            //List<int> numbers = new List<int>() { 1, 5, 4, 7, 8, 9, 3 };
            //var oddNumbers = numbers.Where(x => x % 2 == 1);

            //numbers.AddRange([10, 11, 12, 13, 14]); 
            //foreach (int number in oddNumbers) //foreach is a display loop only can't be used to update
            //    Console.WriteLine(number);

            //Immediate Execution
            //element operators, casting operators, aggregation operators
            //List<int> numbers = new List<int>() { 1, 5, 4, 7, 8, 9, 3 };
            //var oddNumbers = numbers.Where(x => x % 2 == 1).ToList(); // here it's casting immediate

            //numbers.AddRange([10, 11, 12, 13, 14]); 
            //foreach (int number in oddNumbers) 
            //    Console.WriteLine(number);

            #endregion


        }
    }
}