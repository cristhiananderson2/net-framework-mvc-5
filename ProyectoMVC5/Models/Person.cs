using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoMVC5.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public static class PersonDAL
    {
        public static List<Person> List()
        {
            return new List<Person>{
                new Person
                         {
                    Id = 1,
                    Name = "Cristhian Anderson",
                    LastName = "Gómez Culquichicoin"
                },
                new Person
                {
                    Id = 1,
                    Name = "Jenny Isabel",
                    LastName = "Moreno Plasencia"
                },
                new Person
                {
                    Id = 1,
                    Name = "Karen Alexandra",
                    LastName = "Gómez Culquichicoin"
                }
            };
        }
    }
}