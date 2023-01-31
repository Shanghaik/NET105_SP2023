using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DbContext
{
    internal class AppDbContext
    {
        DbSet<Sinhvien> sinhviens { get; set; }   
    }
}
