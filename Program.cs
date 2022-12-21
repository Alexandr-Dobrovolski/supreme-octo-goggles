using System;

namespace SPZ_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp1 = new Employee(
                "Alexandr Dobrovolski",
                EmployeePosition.Engineer,
                "Town#123"
                );
            Employee emp2 = new Employee(
                "Ivanov Ivan",
                EmployeePosition.Versatile,
                "Lasure#657"
                );
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            emp1.setDepartmentName("KURO#629");
            emp1.setEmployeePosition(EmployeePosition.Director);
            Console.WriteLine(emp1);

            Console.WriteLine(emp1.findFirsInEmployeeHistory("Engineer"));
            Console.WriteLine(emp1.findFirsInEmployeeHistory("Director"));

            Console.WriteLine(emp1 > emp2);

        }
    }

}
