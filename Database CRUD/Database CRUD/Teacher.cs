using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_CRUD
{
    public class Teacher:BaseModel
    {
        public int TscNo { get; set; }
        public ICollection<Student> students { get; set; } //// Navigation property for the one-to-many relationship with student

    }
}
