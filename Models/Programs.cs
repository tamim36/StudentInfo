using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Programs
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public Student Student { get; set; }
    }
}
