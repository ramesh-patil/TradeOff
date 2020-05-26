using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradeOffAPI.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string EamilId { get; set; }
        
        [Column(TypeName = "nvarchar(15)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DOB { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string gender { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string address { get; set; }

    }
}
