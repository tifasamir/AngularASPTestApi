using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApicore31.Models;

namespace TestApicore31.Data
{
    public class TestDataAccessLayer
    {
        TestapiContext db = new TestapiContext();

        public IEnumerable<Tbl001> GetAllEmployees()
        {
            try
            {
                return db.Tbl001.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record   
        public int AddEmployee(Tbl001 employee)
        {
            try
            {
                Console.Write(employee);
                db.Tbl001.Add(employee);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee  
        public int UpdateEmployee(Tbl001 employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee  
        public Tbl001 GetEmployeeData(long id)
        {
            try
            {
                Tbl001 employee = db.Tbl001.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular employee  
        public int DeleteEmployee(int id)
        {
            try
            {
                Tbl001 emp = db.Tbl001.Find(id);
                db.Tbl001.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        ////To Get the list of Cities  
        //public List<TblCities> GetCities()
        //{
        //    List<TblCities> lstCity = new List<TblCities>();
        //    lstCity = (from CityList in db.TblCities select CityList).ToList();

        //    return lstCity;
        //}
    }
}

