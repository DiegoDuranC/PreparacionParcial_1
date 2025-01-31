﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiCountry.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiCountry.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<ApiCountry.Models.Country> Countries { get; set; }
    }
}