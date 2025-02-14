﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryActivity { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
