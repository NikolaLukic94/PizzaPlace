﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class ICategoryInterface
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
