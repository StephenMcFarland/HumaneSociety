using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HumaneSociety.Models
{
    public class Humane
    {
       
            public int HumaneID { get; set; }
            public string Name { get; set; }
            public string AnimalType { get; set; }
    }

        public class HumaneDBContext : DbContext
        {
            public DbSet<Humane> Humanes { get; set; }

        }
    }