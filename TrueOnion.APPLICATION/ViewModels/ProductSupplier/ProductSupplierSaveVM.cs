﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;

namespace TrueOnion.APPLICATION.ViewModels.ProductSupplier
{
    public class ProductSupplierSaveVM : SaveVM
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public int MaxCountPerShipping { get; set; }
    }
}