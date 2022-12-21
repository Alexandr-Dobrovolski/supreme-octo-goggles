using System;
using System.Text.RegularExpressions;

namespace SPZ_Lab1
{
    class EmployeeNameValidator
    {
        static public string validFullNameChar = @"[a-zA-ZА-Яа-я]{1,}\s{1}[a-zA-Zа-яА-Я]{1,}$";
        static public string validDepartmentName = @"[a-zA-ZА-Яа-я]{1,}#?[0-9]{1,}$";
        static public bool isValidFullName(string name)
        {
            return isValidString(name, validFullNameChar);

        }
        static public bool isValidDepartmentName(string name)
        {
            return isValidString(name, validDepartmentName);
        }

        private static bool isValidString(string name,string reg)
        {
            if (String.IsNullOrEmpty(name))
            {
                return false;
            }
            if (!Regex.IsMatch(name, reg))
            {
                return false;
            }
            return true;
        }
    }
}
