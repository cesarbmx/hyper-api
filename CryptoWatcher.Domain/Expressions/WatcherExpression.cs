﻿using System;
using System.Linq.Expressions;
using CryptoWatcher.Domain.Models;

namespace CryptoWatcher.Domain.Expressions
{
    public static class WatcherExpression
    {
        public static Expression<Func<Watcher, bool>> Filter(string userId)
        {
            return x => x.UserId == userId;
        }
        public static Expression<Func<Watcher, bool>> WatcherWillingToBuy()
        {
            return x => x.Status == WatcherStatus.Buy;
        }
        public static Expression<Func<Watcher, bool>> WatcherWillingToSell()
        {
            return x => x.Status == WatcherStatus.Sell;
        }
        public static Expression<Func<Watcher, bool>> Watcher(string userId, string currencyId, IndicatorType indicatorType)
        {
            return x =>
                x.UserId == userId &&
                x.CurrencyId == currencyId &&
                x.IndicatorType == indicatorType;
        }
    }
}