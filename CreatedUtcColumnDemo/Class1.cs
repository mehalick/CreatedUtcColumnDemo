using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CreatedUtcColumnDemo
{
    public class Product : EntityBase
    {
        public int ProductId { get; set; }
        public string Name { get; set; }  
    }

    public abstract class EntityBase
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedUtc { get; set; }
    }

    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
