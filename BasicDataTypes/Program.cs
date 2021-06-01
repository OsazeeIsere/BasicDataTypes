using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            NewinDataType();
            DataTypeFunctionality();
            CharFunctionality();
            TryParseFromStringsWithTryParse();
            UseDateAndTime();
            UseBigInteger();
        }

         static void UseBigInteger()
        {
            Console.WriteLine("=> Use big data");
            BigInteger biggy = BigInteger.Parse("999999999999999999999999999999999" +
                "99999999");
            Console.WriteLine("the value of biggy is:{0}",biggy);
            Console.WriteLine("Is the Value {0} even number {1}",biggy,biggy.IsEven);
            Console.WriteLine("Is biggy a power of two {0}",biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("888888" +
                "8888888888888888888888888888888888"));
            Console.WriteLine("The value of reallyBig is:{0}",reallyBig);


        }

        static void UseDateAndTime()
        {
            Console.WriteLine("=> Use date and time");
            // this constructor takes (year, month, day)
            DateTime dt = new DateTime(2000, 06, 01); //date that this code was writen

            // what day of the month is this
            Console.WriteLine("the day of this {0} is {1}",dt, dt.DayOfYear);

            // month is now december
            dt = dt.AddMonths(6);
            Console.WriteLine("dayLight savings: {0}",dt.IsDaylightSavingTime());

            //this constructor takes (hour,minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 15, 0);
            Console.WriteLine(ts);

            // substrat 15 minutes from the current timespan 
            // and print the result
            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));







        }

        private static void TryParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> data types parsing with TryParse");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            string value = "Hello";
            if(double.TryParse(value,out double d))
            {
                Console.WriteLine(" Value of d: {0}",d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to" +
                    "a double",value);
            }
            if (DateTime.TryParse("12/2/2021",out DateTime dt))
            {
                Console.WriteLine("date is:{0}",dt.ToShortDateString());//takes away time from the date
            }
            else
            {
                Console.WriteLine("cannot convert the string to date");
            }
            Console.WriteLine();
        }

        private static void CharFunctionality()
        {
            Console.WriteLine("=> Char type functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a') {0}",char.IsDigit(myChar));
            Console.WriteLine("char.letter('a') {0}",char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace (Hello There, 5): {0}",
                char.IsWhiteSpace(" Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace (Hello There, 6): {0}",
               char.IsWhiteSpace(" Hello There", 6));
            Console.WriteLine("char.punctuation('?'): {0}",char.IsPunctuation
                ('?'));
            Console.WriteLine();
        }


        private static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type functionality");
            Console.WriteLine("Max of int {0}",int.MaxValue);
            Console.WriteLine("Min of int {0}",int.MinValue);
            Console.WriteLine("Max of double {0}",double.MaxValue);
            Console.WriteLine("Min of double {0}",double.MinValue);
            Console.WriteLine("double.Epsilon: {0}",double.Epsilon);
            Console.WriteLine("double.positiveInfinity {0}",double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity {0}", double.NegativeInfinity);
            Console.WriteLine("bool.FalseString: {0}",bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}",bool.TrueString);

        }

        private static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data decarations");
            //local variables are declared as so:
            //dataType varName =initialvalue;
            int myInt=0;

            //you can  also declared and assigned on two lines
            string myString;
            myString = "This is character data";

            //declare 3 bools on the same line
            bool b1 = true, b2 = false, b3 = b1;

            //use system.Boolian data type to declare a bool
            System.Boolean b4 = false;
            Console.WriteLine("Your Data: {0},{1},{2},{3},{4}",myInt,myString,
                b1,b2,b3,b4);
            Console.ReadLine();
        }

        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;
        }
        static void NewinDataType()
        {
            Console.WriteLine("=> Using New to create Variables:");
            bool b = new bool(); //set to false
            int i = new int(); // set to 0.
            double d = new double(); //SET to 0.
            DateTime dt = new DateTime(); // set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3} ",b,i,d,dt);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
