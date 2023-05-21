using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem.Data.Tables
{
    public class MetascreenStruct
    {
       
        public int Id { get; set; }
        public string NameOfStruct { get; set; }
        
    }
}
