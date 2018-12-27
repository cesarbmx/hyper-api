﻿using CryptoWatcher.Application.Indicators.Requests;



namespace CryptoWatcher.Application.Indicators.FakeRequests
{
    public static class AddIndicatorFakeRequest
    {
        public static AddIndicatorRequest GetFake_1()
        {
            return new AddIndicatorRequest
            {
                IndicatorId = "hype",
                UserId = "johny.melavo",
                Name = "Hype",
                Description = "It identifies immediate hypes within 24 Hrs in your portfolio",
                Formula = "C# formula"
            };
        }       
    }
}