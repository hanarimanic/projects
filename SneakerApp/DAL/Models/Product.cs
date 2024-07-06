using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }

    public int? UnitsInStock { get; set; }

    public int? CategoryId { get; set; }

    public string Brand { get; set; } = null!;

    public string? Size { get; set; }

    public string? Model { get; set; }

    public string? Color { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
