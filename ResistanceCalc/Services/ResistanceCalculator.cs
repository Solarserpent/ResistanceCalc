using ResistanceCalc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistanceCalc.Services
{
    public class ResistanceCalculator : IOhmValueCalculator
    {
        public static readonly Dictionary<string, int> ResistanceValueMap = new Dictionary<string, int>()
        {
            { "Black", 0  },
            { "Brown", 1  },
            { "Red", 2 },
            { "Orange", 3  },
            { "Yellow", 4  },
            { "Green", 5 },
            { "Blue", 6  },
            { "Violet", 7  },
            { "Gray", 8 },
            { "White", 9 }
        };

        public static readonly Dictionary<string, decimal> ResistanceMagnitudeMap = new Dictionary<string, decimal>()
        {
            { "Pink",   .001M  },
            { "Silver", .01M  },
            { "Gold",   .1M },
            { "Black",  1M  },
            { "Brown",  10M  },
            { "Red",    100M },
            { "Orange", 1000M  },
            { "Yellow", 10000M  },
            { "Green",  100000M },
            { "Blue",   1000000M  },
            { "Violet", 10000000M  },
            { "Gray",   100000000M },
            { "White",  1000000000M }
        };


        public static readonly Dictionary<string, decimal> ResistanceToleranceMap = new Dictionary<string, decimal>()
        {
            { "None",    20M },
            { "Silver",  10M },
            { "Gold",    5M },
            { "Brown",   1M },
            { "Red",     2M },
            { "Green",  0.5M },
            { "Blue",   0.25M },
            { "Violet", 0.1M },
            { "Gray",   0.05M }
        };



        public string CalculateResistance(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            (decimal value, decimal tolerance) = CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
            if (value == decimal.MinusOne)
                return "Incorrect Color Given";
            else
                return $"{value}Ω ±{tolerance}%";

        }

        public (decimal value, decimal tolerance) CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            if (CheckInputs(bandAColor, bandBColor, bandCColor, bandDColor))
            {
                decimal value = (ResistanceValueMap[bandAColor] * 10 + ResistanceValueMap[bandBColor]) * ResistanceMagnitudeMap[bandCColor];
                return (value, ResistanceToleranceMap[bandDColor]);
            }
            else
                return (decimal.MinusOne, decimal.MinusOne);
        }

        private bool CheckInputs(string colorA, string colorB, string colorC, string colorD)
        {
            if (colorA != null && ResistanceValueMap.ContainsKey(colorA) &&
                colorB != null && ResistanceValueMap.ContainsKey(colorB) &&
                colorC != null && ResistanceMagnitudeMap.ContainsKey(colorC) &&
                colorD != null && ResistanceToleranceMap.ContainsKey(colorD))
                return true;
            return false;
        }
    }
}
