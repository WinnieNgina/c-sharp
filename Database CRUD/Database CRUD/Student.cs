using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_CRUD
{
    public class Student:BaseModel
    {
        [ForeignKey("Teacher")] // specifies that this teacher id is a foreign to the student table
        public int? TeacherId { get; set; } //?specifies its nullable. Column can be NULL
        public Teacher Mwalimu { get; set; } //Navigation property to represent the many-to-one relationship with teacher
    }
}
