using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssignmentStudent
{
    public class Test
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string TestName { get; set; }
        public decimal Score { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
