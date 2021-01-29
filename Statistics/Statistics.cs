using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            Stats stats = new Stats();
            stats.average = numbers.ToArray().Average();
            stats.max = numbers.ToArray().Max();
            stats.min = numbers.ToArray().Min();

            return stats;
        }
    }
    
    public class Stats
    {
        public double average { get; set; }
        public double max { get; set; }
        public double min { get; set; }
    }
}
