namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int EmpAge;
            int Salary;

            Console.Write("Enter Employee name :  ");
            string EmpName = Console.ReadLine();

            Console.Write("Enter Employee ID :  ");
            int EmpID = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Enter student Age :  ");
                EmpAge = int.Parse(Console.ReadLine());

            } while (EmpAge < 0);

            do
            {
                Console.Write("Enter Employee Salary :  ");
                Salary = int.Parse(Console.ReadLine());
            } while (Salary < 30000);

            Console.Write($"Your name is : {EmpName} \n  Your Age is : {EmpAge} \n  Your ID is : {EmpID}  \n Your Salary is : {Salary} ");
        }
    }
}
