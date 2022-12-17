using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;

namespace TrueOnion.APPLICATION.ViewModels.Category
{
    public class CategorySaveVM : ISaveVM
    {
        [DisplayName("Category Name")]
        public string Name { get; set; }
    }
}