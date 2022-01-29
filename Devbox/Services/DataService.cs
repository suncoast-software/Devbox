using Devbox.Data.Config;
using Devbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Services
{
    internal class DataService : IDataService
    {
        public ConfigJson GetConnectionString()
        {
            return new ConfigJson();
        }
    }
}
