using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIntro.Services.Interfaces
{
    internal interface IDataDownloadService
    {
        public string DownloadJson(string uri);
    }
}
