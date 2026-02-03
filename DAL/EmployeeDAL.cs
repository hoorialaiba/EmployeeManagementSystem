using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class EmployeeDAL
    {
        public List<EmployeeDTO> GetAll() 
        {
            StreamReader sr = new StreamReader("employee.txt");
            string data = sr.ReadLine();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            while (data != null)
            {
                EmployeeDTO et = new EmployeeDTO();
                string[] st = data.Split(',');
                et.Id = st[0];
                et.Name = st[1];
                et.Age = int.Parse(st[2]);
                et.Department = st[3];
                et.Salary = float.Parse(st[4]);
                et.Date = st[5];
                list.Add(et);
                data = sr.ReadLine();

            }
            sr.Close();
            return list;
        }
        public void add(EmployeeDTO e) 
        {
            StreamWriter sw = new StreamWriter("employee.txt", true);
            string data = $"{e.Id},{e.Name},{e.Age},{e.Department},{e.Salary},{e.Date}";
            sw.WriteLine(data);
            sw.Close();
        }
        public void del(EmployeeDTO e)
        {
            StreamReader sr = new StreamReader("employee.txt");
            string data = sr.ReadLine();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            while (data != null)
            {
                EmployeeDTO et = new EmployeeDTO();
                string[] st = data.Split(',');
                et.Id = st[0];
                et.Name = st[1];
                et.Age = int.Parse(st[2]);
                et.Department = st[3];
                et.Salary = float.Parse(st[4]);
                et.Date = st[5];
                if (e.Id != et.Id)
                {
                    list.Add(et);
                }
                data = sr.ReadLine();

            }
            sr.Close();
            StreamWriter sw = new StreamWriter("employee.txt");
            foreach (EmployeeDTO emp in list)
            {
                data = $"{emp.Id},{emp.Name},{emp.Age},{emp.Department},{emp.Salary},{emp.Date}";
                sw.WriteLine(data);
            }
            sw.Close();
        }
        public void updateDName(EmployeeDTO e, string d)
        {
            StreamReader sr = new StreamReader("employee.txt");
            string data = sr.ReadLine();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            while (data != null)
            {
                EmployeeDTO et = new EmployeeDTO();
                string[] st = data.Split(',');
                et.Id = st[0];
                et.Name = st[1];
                et.Age = int.Parse(st[2]);
                et.Department = st[3];
                et.Salary = float.Parse(st[4]);
                et.Date = st[5];
                if (e.Id == et.Id)
                {
                    et.Department = d;
                }
                list.Add(et);
                data = sr.ReadLine();

            }
            sr.Close();
            StreamWriter sw = new StreamWriter("employee.txt");
            foreach (EmployeeDTO emp in list)
            {
                data = $"{emp.Id},{emp.Name},{emp.Age},{emp.Department},{emp.Salary},{emp.Date}";
                sw.WriteLine(data);
            }
            sw.Close();
        }
        public void updateS(EmployeeDTO e, float s)
        {
            StreamReader sr = new StreamReader("employee.txt");
            string data = sr.ReadLine();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            while (data != null)
            {
                EmployeeDTO et = new EmployeeDTO();
                string[] st = data.Split(',');
                et.Id = st[0];
                et.Name = st[1];
                et.Age = int.Parse(st[2]);
                et.Department = st[3];
                et.Salary = float.Parse(st[4]);
                et.Date = st[5];
                if (e.Id == et.Id)
                {
                    et.Salary = s;
                }
                list.Add(et);
                data = sr.ReadLine();

            }
            sr.Close();
            StreamWriter sw = new StreamWriter("employee.txt");
            foreach (EmployeeDTO emp in list)
            {
                data = $"{emp.Id},{emp.Name},{emp.Age},{emp.Department},{emp.Salary},{emp.Date}";
                sw.WriteLine(data);
            }
            sw.Close();
        }
    }
}
