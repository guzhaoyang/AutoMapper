using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModel.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Sex { get; set; }
    }
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }

    public class Score
    {
        [Key]
        public int Id { get; set; }

        public int StudentScore { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }

    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("StudentContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Score> Scores { get; set; }

        /// <summary>
        /// OnModelCreating方法中的modelBuilder.Conventions.Remove语句禁止表名称正在多元化。如果你不这样做，所生成的表将命名为Students、Courses和Enrollments。相反，表名称将是Student、Course和Enrollment。开发商不同意关于表名称应该多数。本教程使用的是单数形式，但重要的一点是，您可以选择哪个你更喜欢通过包括或省略这行代码的形式。
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

}
