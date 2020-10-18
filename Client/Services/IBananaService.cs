﻿using System;

namespace BlazorBattle2.Client.Services
{
    public interface IBananaService
    {
        event Action OnChange;

        int Bananas { get; set; }

        void EatBananas(int amount);

        void AddBananas(int amount);
    }
}