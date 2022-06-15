using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProductServices.Models
{
    [Table("customers", Schema = "sales")]
    public class Product
    {
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("product_name")]
        public string ProductName { get; set; }

        [Column("brand_id")]
        public int BrandId { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("model_year")]
        public short ModelYear { get; set; }

        [Column("list_price")]
        public decimal ListPrice { get; set; }
    }
}