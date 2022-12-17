using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOnion.APPLICATION.ViewModels.ResultTypeViewModels
{
    public class ErrorVM
    {
        public ErrorVM()
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }
    }
}
