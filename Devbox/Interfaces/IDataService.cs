using Devbox.Data.Config;

namespace Devbox.Interfaces
{
    internal interface IDataService
    {
        public ConfigJson GetConnectionString();
    }
}
