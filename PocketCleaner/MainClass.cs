using System;
using Exiled.API.Features;

namespace PocketCleaner
{
    public class MainClass : Plugin<Config>
    {
        public override string Author { get; } = "xNexusACS";
        public override string Name { get; } = "PocketCleaner";
        public override string Prefix { get; } = "pocketcleaner";
        public override Version Version { get; } = new Version(0, 1, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 2);
        
        public EventHandlers EventHandlers { get; private set; }
        
        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers();

            Exiled.Events.Handlers.Player.Dying += EventHandlers.OnDying;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Dying -= EventHandlers.OnDying;
            
            EventHandlers = null;
            base.OnDisabled();
        }
    }
}