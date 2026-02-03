using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DepartmentDAL
    {
        public List<DepartmentDTO> GetAll()
        {
            StreamReader sr = new StreamReader("department.txt");
            string data = sr.ReadLine();
            List<DepartmentDTO> list = new List<DepartmentDTO>();
            while (data != null)
            {
                DepartmentDTO et = new DepartmentDTO();
                string[] st = data.Split(',');
                et.Id = int.Parse(st[0]);
                et.Name = st[1];
                et.Description = st[2];
                list.Add(et);
                data = sr.ReadLine();

            }
            sr.Close();
            return list;
        }
        public void add(DepartmentDTO e)
        {
            StreamWriter sw = new StreamWriter("department.txt", true);
            string data = $"{e.Id},{e.Name},{e.Description}";
            sw.WriteLine(data);
            sw.Close();
        }
        public void del(DepartmentDTO e)
        {
            StreamReader sr = new StreamReader("department.txt");
            string data = sr.ReadLine();
            List<DepartmentDTO> list = new List<DepartmentDTO>();
            while (data != null)
            {
                DepartmentDTO et = new DepartmentDTO();
                string[] st = data.Split(',');
                et.Id = int.Parse(st[0]);
                et.Name = st[1];
                et.Description = st[2];
                if (e.Name != et.Name)
                {
                    list.Add(et);
                }
                data = sr.ReadLine();

            }
            sr.Close();
            StreamWriter sw = new StreamWriter("department.txt");
            foreach (DepartmentDTO emp in list)
            {
                data = $"{emp.Id},{emp.Name},{emp.Description}";
                sw.WriteLine(data);
            }
            sw.Close();
        }
        public void editDept(DepartmentDTO e, string des)
        {
            StreamReader sr = new StreamReader("department.txt");
            string data = sr.ReadLine();
            List<DepartmentDTO> list = new List<DepartmentDTO>();
            while (data != null)
            {
                DepartmentDTO et = new DepartmentDTO();
                string[] st = data.Split(',');
                et.Id = int.Parse(st[0]);
                et.Name = st[1];
                et.Description = st[2];
                if (e.Name == et.Name)
                {
                    et.Description = des;
                }
                list.Add(et);
                data = sr.ReadLine();

            }
            sr.Close();
            StreamWriter sw = new StreamWriter("department.txt");
            foreach (DepartmentDTO emp in list)
            {
                data = $"{emp.Id},{emp.Name},{emp.Description}";
                sw.WriteLine(data);
            }
            sw.Close();
        }
    }
}
