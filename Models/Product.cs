using System;
using System.Collections.Generic;

namespace Prueba.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; } = null!;
    }
}
