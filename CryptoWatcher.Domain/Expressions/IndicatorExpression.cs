﻿using System;
using System.Linq.Expressions;
using CryptoWatcher.Domain.Models;

namespace CryptoWatcher.Domain.Expressions
{
    public static class IndicatorExpression
    {
        public static Expression<Func<Indicator, bool>> Filter(string indicatorId = null, string userId = null)
        {
            return x =>  (string.IsNullOrEmpty(indicatorId) || x.IndicatorId == indicatorId) &&
                         (string.IsNullOrEmpty(userId) || x.UserId == userId);
        }       
    }
}
