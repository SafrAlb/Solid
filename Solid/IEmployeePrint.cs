using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public interface IEmployeePrint
    {
        void PrintEmployeeInfo(Employee employee, double salary);
    }

    public class ConsoleEmployeePrint : IEmployeePrint
    {
        public void PrintEmployeeInfo(Employee employee, double salary)
        {
            Console.WriteLine($"Сотрудник: {employee.Name}, Зарплата: {salary}");
        }
    }
}
