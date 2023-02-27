namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Manager m1 = new Manager ( 100, "ziad",  180, 10 );
            Maintanance m2 = new Maintanance (101, "Ali", 182, 8);
            Sales m3 = new Sales (   103, "said", 160, 9,160,1000m );
            Devoper m4 = new Devoper( 104,"ahmed", 182,  8 ,true);

            Empyoyee[] empyoyees =  { m1, m2, m3, m4 };
            foreach (var employee in empyoyees)
            {
                Console.WriteLine("\n----------------");
                Console.WriteLine(employee);
            }
            Console.ReadKey();
        }
    }

}