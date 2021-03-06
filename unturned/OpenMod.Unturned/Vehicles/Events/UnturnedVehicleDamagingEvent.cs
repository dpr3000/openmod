﻿using OpenMod.API.Eventing;
using SDG.Unturned;
using Steamworks;

namespace OpenMod.Unturned.Vehicles.Events
{
    public class UnturnedVehicleDamagingEvent : UnturnedVehicleEvent, ICancellableEvent
    {
        public CSteamID Instigator { get; }

        public ushort PendingTotalDamage { get; set; }

        public EDamageOrigin DamageOrigin { get; }

        public bool CanRepair { get; set; }

        public bool IsCancelled { get; set; }

        public UnturnedVehicleDamagingEvent(UnturnedVehicle vehicle, CSteamID instigator, ushort pendingTotalDamage, EDamageOrigin damageOrigin, bool canRepair) : base(vehicle)
        {
            Instigator = instigator;
            PendingTotalDamage = pendingTotalDamage;
            DamageOrigin = damageOrigin;
            CanRepair = canRepair;
        }
    }
}
