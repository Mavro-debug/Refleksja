using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refleksja
{
    public static class EmployeeProvider
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){
                    Id = 0,
                    Name = "Adam Adamczyk",
                    Position = Positions.Accountant,
                    ContactInformation = new ContactInfo
                    {
                        Telephone = "+48 561 547 645",
                        City = "Warszawa",
                        Street = "Międzyrzecka 21"
                    }
                },
                new Employee(){
                    Id = 1,
                    Name = "Eryk Jankowski",
                    Position = Positions.Manager,
                    ContactInformation = new ContactInfo
                    {
                        Telephone = "+48 545 447 655",
                        City = "Warszawa",
                        Street = "Orłowska 28"
                    }
                },
                new Employee(){
                    Id = 2,
                    Name = "Anna Wysocka",
                    Position = Positions.Seller,
                    ContactInformation = new ContactInfo
                    {
                        Telephone = "+48 856 159 842",
                        City = "Warszawa",
                        Street = "Msia 74"
                    }
                },
                new Employee(){
                    Id = 3,
                    Name = "Marek Storczyk",
                    Position = Positions.Conservator,
                    ContactInformation = new ContactInfo
                    {
                        Telephone = "+48 862 486 268",
                        City = "Warszawa",
                        Street = "Owczarska 89"
                    }
                },
            };

            return employees;
        }
    }
}
