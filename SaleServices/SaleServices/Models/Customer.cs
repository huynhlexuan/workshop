using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerServices.Models
{
    [Table("customers", Schema = "sales")]
    public class Customer
    {
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("street")]
        public string Street { get; set; }

        [Column("zip_code")]
        public string ZipCode { get; set; }
        
    }
}