using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.DTOs;

namespace TrueOnion.APPLICATION.Services
{
    public interface IEMailService
    {
        Task SendAsync(EMailDTO req);
    }
}
