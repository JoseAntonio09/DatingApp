//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace NetCoreEjercices
{
    class Program
    {
        static void Main(string[] args)
        {
            ///generic = "not specific to a particular data type"
            ///          add<T> to: classes, methods, fields, etc.
            ///          allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            //displayElements(intArray);
            //displayElements(doubleArray);
            //displayElements(stringArray);

            //Console.ReadKey();

            ///-----Partial Class--------
            Person oPerson = new Person();
            oPerson.Name = "Jose";
            oPerson.LastName = "Sanchez";
            Console.WriteLine(oPerson.GetFullName());


            //---Encapsulation----
            Employee objEmployee = new Employee();
            objEmployee.EmpExperience = 3;
            Console.WriteLine("The value that has been encapsulate are: " + "" + objEmployee.EmpExperience);


            ///----Dependency Injection
            var user1 = new User("Tim");
            user1.ChangeUsername("Robert");
            Console.ReadKey();


            ///---SOLID PRINCIPLES
            SavingAccount objSavingAccount = new SavingAccount();
            objSavingAccount.CalculateInterest();
            Console.WriteLine(objSavingAccount);



        }

        public class Employee
        {
            ///Make a field private

            private int empExperience;

            public int EmpExperience
            {
                get { return empExperience; }
                set { empExperience = value; }
            
            }
        
        }

        
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + "");

            }

        }


    }

}