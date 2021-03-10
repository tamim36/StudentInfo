using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<AcademicInfo> AcademicInfos { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<ExamType> ExamTypes { get; set; }
        public DbSet<Programs> Programss { get; set; }
        public DbSet<PassingYear> PassingYears { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
