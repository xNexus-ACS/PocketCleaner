using Exiled.Events.EventArgs;
using PlayerStatsSystem;

namespace PocketCleaner
{
    public class EventHandlers
    {
        public void OnDying(DyingEventArgs ev)
        {
            if (ev.Handler.Base is UniversalDamageHandler universal)
            {
                if (universal.TranslationId == DeathTranslations.PocketDecay.Id)
                {
                    ev.Target.Ammo.Clear();
                    ev.Target.Inventory.SendAmmoNextFrame = true;
                    ev.Target.ClearInventory();
                }
            }
        }
    }
}