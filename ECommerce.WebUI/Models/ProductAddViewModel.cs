﻿using ECommerce.Domain.Entites;

namespace ECommerce.WebUI;

public class ProductAddViewModel
{
    public Product Product { get; set; }
    public List<Category> Categories { get; set; }
}