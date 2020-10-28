using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser.POCO
{
    public class USCensusDAO
    {
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public USCensusDAO(string housingUnits, string totalArea, string waterArea, string landArea, string populationDensity, string housingDensity)
        {
            this.housingUnits = long.Parse(housingUnits);
            this.totalArea = double.Parse(totalArea);
            this.waterArea = double.Parse(waterArea);
            this.landArea = double.Parse(landArea);
            this.populationDensity = double.Parse(populationDensity);
            this.housingDensity = double.Parse(housingDensity);
        }
    }
}
