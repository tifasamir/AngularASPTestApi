using System;
using System.Collections.Generic;

namespace TestApicore31.Models
{
    public partial class Tbl001
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public long? DeptId { get; set; }
        public decimal? Salary { get; set; }
        public string NationalId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
