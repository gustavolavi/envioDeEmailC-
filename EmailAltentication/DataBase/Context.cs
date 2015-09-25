using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmailAltentication.Models;
using System.Data.Entity;

namespace EmailAltentication.DataBase
{
    public class Context : DbContext
    {
        public Context() :base("conection") { }

        public DbSet<Login> Login { get; set; }
    }
}