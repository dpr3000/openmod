﻿using OpenMod.Extensions.Games.Abstractions.Players;
using OpenMod.Unturned.Entities;
using SDG.Unturned;
using Steamworks;
using System.Numerics;

namespace OpenMod.Unturned.Events.Players.Life
{
    public class UnturnedPlayerDeathEvent : UnturnedPlayerEvent, IPlayerDeathEvent
    {
        public UnturnedPlayerDeathEvent(UnturnedPlayer player, EDeathCause cause, ELimb limb, CSteamID instigator) : base(player)
        {
            DeathCause = cause;
            Limb = limb;
            Instigator = instigator;
        }

        public EDeathCause DeathCause { get; }

        public ELimb Limb { get; }

        public CSteamID Instigator { get; }

        public Vector3 DeathPosition => Player.Transform.Position;
    }
}