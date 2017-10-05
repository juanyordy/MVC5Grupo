using DataAccess.clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataContex
{
   public class DataBaseContex: DbContext
    {
        public DataBaseContex() : base("MyConexion")
        {

        }
        public DbSet<PersonaJuridica> PersonaJuridica{get;set;}
        public DbSet<PersonaNatural> PersonaNatural { get; set; }
    }
}
