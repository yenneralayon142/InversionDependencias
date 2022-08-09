using System.Collections.Generic;

namespace IDLaboratorio
{
    internal class EmployeeManager
    {
        public class EmployeeManager
        {
            private readonly List<Employee> _employees;

            public EmployeeManager()
            {
                _employees = new List<Employee>();
            }

            public void AddEmployee(Employee employee)
            {
                _employees.Add(employee);
            }

        }

    }
    
}
