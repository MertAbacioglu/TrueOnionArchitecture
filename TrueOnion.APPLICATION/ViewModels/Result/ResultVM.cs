using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.ViewModels.Abstracts;
using TrueOnion.APPLICATION.ViewModels.Product;
using TrueOnion.APPLICATION.Wrappers;

namespace TrueOnion.APPLICATION.ViewModels.Response
{
    public abstract class ResultVM<T> where T : IBaseVM
    {
        public Result<List<T>> Result { get; set; }
    }
}