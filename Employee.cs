using System;
using System.Collections.Generic;

namespace SPZ_Lab1
{
    class Employee
    {

        // Поля класса 
        private string _fullName;
        private EmployeePosition _employeePosition;
        private int _salory;
        private List<string> _employeeHistory;
        private string _departmentName;
        // Методы 
        public void setDepartmentName(string department)
        {
            if(_departmentName != department)
            {
                departmentName = department;
                _employeeHistory.Add(_departmentName);
            }
        }
        public void setEmployeePosition(EmployeePosition position)
        {
            if(_employeePosition != position)
            {
                _employeePosition = position;
                salory = 0;
                _employeeHistory.Add(_employeePosition.ToString());
            }
        }
        public int findFirsInEmployeeHistory(string tofind)
        {
            for(int itemIndex = 0;itemIndex < _employeeHistory.Count; itemIndex++)
            {
                if(_employeeHistory[itemIndex] == tofind)
                {
                    return itemIndex;
                }
            }
            return -1;
        }
        public void payroll()
        {
            // value += _salory
        }
        public override string ToString()
        {
            return $"Employee {_fullName} from the department {_departmentName} in the positions of {_employeePosition.ToString()} with a salary of {_salory}";
        }

        public static bool operator>(Employee e1,Employee e2)
        {
            return e1._employeePosition > e2._employeePosition;
        }
        public static bool operator <(Employee e1, Employee e2)
        {
            return !(e1 > e2);
        }
        //Конструкторы
        public Employee(string fullName,
            EmployeePosition employeePosition,
            string departmentName)
        {
            this.fullName = fullName;
            this._employeePosition = employeePosition;
            this.departmentName = departmentName;
            salory = 0;

            _employeeHistory = new List<string>();
            _employeeHistory.Add(departmentName);
            _employeeHistory.Add(employeePosition.ToString());
        }
        // Свойства наших полей 
        private int salory
        {
            get => _salory;
            set => _salory = (int)_employeePosition;
        }
        public string fullName
        {
            get => _fullName;
            set
            {
                if (!EmployeeNameValidator.isValidFullName(value))
                {
                    throw new FormatException();
                }

                _fullName = value;
            }
        }
        private string departmentName
        {
            get => _departmentName;
            set
            {
                if (!EmployeeNameValidator.isValidDepartmentName(value)) 
                {
                    throw new FormatException();
                }
                _departmentName = value;
            }
        }

    }
}
