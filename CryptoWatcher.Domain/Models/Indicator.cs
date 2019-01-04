﻿using System;

namespace CryptoWatcher.Domain.Models
{
    public class Indicator : IEntity
    {
        public string Id => IndicatorId;
        public IndicatorType IndicatorType { get; private set; }
        public string IndicatorId { get; private set; }
        public string UserId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Formula { get; private set; }
        public string Dependencies { get; private set; }
        public int DependencyLevel { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime Time { get; private set; }

        public Indicator() { }
        public Indicator(
            IndicatorType indicatorType,
            string indicatorId,
            string userId,
            string name, 
            string description,
            string formula,
            string dependencies,
            int dependencyLevel)
        {
            IndicatorType = indicatorType;
            IndicatorId = indicatorId;
            UserId = userId;
            Name = name;
            Description = description;
            Formula = formula;
            Dependencies = dependencies;
            DependencyLevel = dependencyLevel;
            CreatedBy = userId;
            Time = DateTime.Now;
        }

        public Indicator Update(string name, string description, string formula)
        {
            Name = name;
            Description = description;
            Formula = formula;

            return this;
        }
        public Indicator UpdateDependencyTree(string name, string description, string formula)
        {
            Name = name;
            Description = description;
            Formula = formula;

            return this;
        }
    }
}
