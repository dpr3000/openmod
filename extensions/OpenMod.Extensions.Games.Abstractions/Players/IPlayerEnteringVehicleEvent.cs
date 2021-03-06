﻿using OpenMod.API.Eventing;
using OpenMod.Extensions.Games.Abstractions.Vehicles;

namespace OpenMod.Extensions.Games.Abstractions.Players
{
    public interface IPlayerEnteringVehicleEvent : IPlayerEvent, IVehicleEvent, ICancellableEvent
    {
    }
}