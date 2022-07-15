using Exiled.API.Interfaces;

namespace PocketCleaner
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}