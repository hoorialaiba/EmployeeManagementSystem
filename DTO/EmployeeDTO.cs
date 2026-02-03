using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        public string id;
        public string name;
        public int age;
        public string department;
        public float salary;
        public string date;
        public string Id 
        {
            get 
            {
                return id;
            }
            set 
            {
                id = value;
            } 
        }
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Department {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public float Salary {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public string Date {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public override string ToString()
        {
            return $"{id}     {name}     {age}      {department}     {salary}        {date}";
        }
    }
}
