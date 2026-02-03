using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Xml.Linq;

namespace BLL
{
    public class EmployeeBLL
    {
        public bool validName(string n)
        {
            if (string.IsNullOrEmpty(n)) return false;
            foreach(char c in n)
            {
                if (!((c >= 'a' && c <= 'z' ) || (c >= 'A' && c <= 'Z') || c == ' '))
                {
                    return false;
                }
            }
            return true;
        }
        public List<EmployeeDTO> GetAll() 
        {
            EmployeeDAL ed = new EmployeeDAL();
            return ed.GetAll();
        }
        public int create(string id, string n, int a, string d, float s, string j) 
        {
            if (searchId(id) != null)
            {
                return -1;                      // -1 means this Id exists already
            }
            if (searchDName(d) == null)
            {
                return -2;                      // -2 means No such department
            }
            if (a < 18 || a > 59)
            {
                return -3;                     // -3 means age is not in valid age limit
            }
            if (validName(n) == false)          
            {
                return -4;                     // -4 means name is not valid
            }
            EmployeeDTO et = new EmployeeDTO();
            et.Id = id;
            et.Name = n;
            et.Age = a;
            et.Department = d;
            et.Salary = s;
            et.Date = j;
            EmployeeDAL ed = new EmployeeDAL();
            ed.add(et);
            return 1;
        }
        public int createDept(int id, string n, string d)
        {
            if (searchDeptId(id) != null)
            {
                return -1;                      // -1 means this Id exists already
            }
            if (searchDName(d) != null)
            {
                return -2;                      // -2 means this department already exist
            }
            if (validName(n) == false)
            {
                return -3;                     // -3 means name is not valid
            }
            DepartmentDTO et = new DepartmentDTO();
            et.Id = id;
            et.Name = n;
            et.Description = d;
            DepartmentDAL ed = new DepartmentDAL();
            ed.add(et);
            return 1;
        }
        public DepartmentDTO searchDeptId(int id)
        {
            DepartmentDAL ed = new DepartmentDAL();
            List<DepartmentDTO> list = new List<DepartmentDTO>();
            list = ed.GetAll();
            DepartmentDTO et = new DepartmentDTO();
            et = null;
            foreach (DepartmentDTO e in list)
            {
                if (e.Id == id)
                {
                    et = e;
                }
            }
            return et;
        }
        public bool updateS(string id, float s) 
        {
            EmployeeDTO e = searchId(id);
            if (searchId(id) != null)
            {
                EmployeeDAL ed = new EmployeeDAL();
                ed.updateS(e, s);
                return true;
            }
            return false;
        }
        public int updateD(string id, string d)
        {
            EmployeeDTO e = searchId(id);
            if (e != null && searchDName(d) != null)
            {
                EmployeeDAL ed = new EmployeeDAL();
                ed.updateDName(e, d);
                return 1;
            }
            if (searchDName(d) == null)
            {
                return -1;
            }
            return 0;
        }
        public bool delete(string id) 
        {
            EmployeeDTO e = searchId(id);
            if (e != null)
            {
                EmployeeDAL ed = new EmployeeDAL();
                ed.del(e);
                return true;
            }
            return false;
        }
        public bool editDept(string d, string des)
        {
            DepartmentDTO e = searchDName(d);
            if (e != null)
            {
                DepartmentDAL ed = new DepartmentDAL();
                ed.editDept(e, des);
                return true;
            }
            return false;
        }
        public bool deleteDept(string d)
        {
            DepartmentDTO e = searchDName(d);
            if (e != null)
            {
                DepartmentDAL ed = new DepartmentDAL();
                ed.del(e);
                return true;
            }
            return false;
        }
        public List<EmployeeDTO> searchName(string name) 
        {
            EmployeeDAL ed = new EmployeeDAL();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            List<EmployeeDTO> emp = new List<EmployeeDTO>();
            list = ed.GetAll();
            foreach (EmployeeDTO e in list) 
            {
                if (e.Name == name)
                {
                    emp.Add(e);
                }
            }
            return emp;
        }

        public List<EmployeeDTO> searchByDepartment(string d)
        {
            EmployeeDAL ed = new EmployeeDAL();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            List<EmployeeDTO> emp = new List<EmployeeDTO>();
            list = ed.GetAll();
            foreach (EmployeeDTO e in list)
            {
                if (e.Department == d)
                {
                    emp.Add(e);
                }
            }
            return emp;
        }
        public List<EmployeeDTO> searchDate(string d)
        {
            EmployeeDAL ed = new EmployeeDAL();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            List<EmployeeDTO> emp = new List<EmployeeDTO>();
            list = ed.GetAll();
            foreach (EmployeeDTO e in list)
            {
                if (e.Date == d)
                {
                    emp.Add(e);
                }
            }
            return emp;
        }
        public DepartmentDTO searchDName(string d)
        {
            DepartmentDAL de = new DepartmentDAL();
            List<DepartmentDTO> list = new List<DepartmentDTO>();
            list = de.GetAll();
            DepartmentDTO dt = null;
            foreach (DepartmentDTO e in list)
            {
                if (e.Name == d)
                {
                    dt = e;
                }
            }
            return dt;
        }
        public EmployeeDTO searchId(string id)
        {
            EmployeeDAL ed = new EmployeeDAL();
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            list = ed.GetAll();
            EmployeeDTO et = new EmployeeDTO();
            et = null;
            foreach (EmployeeDTO e in list)
            {
                if (e.Id == id)
                {
                    et = e;
                }
            }
            return et;
        }
    }
}
