using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Name = "Lucas";
            employee.Age = 33;
            employee.Gender = 'M';

            Employee employeeClone = (Employee)employee.Clone();

            employeeClone.Name = "Fabricio";

            Console.WriteLine($"Funcionario permanente: Nome: {employee.Name}, Idade: {employee.Age}, Sexo: {employee.Gender}");
            Console.WriteLine($"Funcionario clonado: Nome: {employeeClone.Name}, Idade: {employeeClone.Age}, Sexo: {employeeClone.Gender}");

            Console.ReadKey();
        }
    }
}
