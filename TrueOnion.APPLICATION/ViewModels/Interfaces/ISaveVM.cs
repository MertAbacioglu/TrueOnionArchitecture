using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOnion.APPLICATION.ViewModels.Abstracts
{
    public abstract class SaveVM
    {
        public int ID { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
