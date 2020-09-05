using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeSub.Service
{
    public interface ISender
    {
        string Send(string uri);
    }
}
