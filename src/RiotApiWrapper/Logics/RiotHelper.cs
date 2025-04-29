using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Logics
{
    public static class RiotHelper
    {
        public static Dictionary<Platform, Region> PlatformRegionPairs = new() {
            { Platform.BR1, Region.Americas },
            { Platform.EUN1, Region.Europe},
            { Platform.EUW1, Region.Europe},
            { Platform.JP1,  Region.Asia },
            { Platform.KR,   Region.Asia },
            { Platform.LA1,  Region.Americas },
            { Platform.LA2,  Region.Americas },
            { Platform.ME1,  Region.Asia },
            { Platform.NA1,  Region.Americas },
            { Platform.OC1,  Region.SEA },
            { Platform.RU,   Region.Europe },
            { Platform.SG2,  Region.SEA },
            { Platform.TR1,  Region.Europe },
            { Platform.TW2,  Region.SEA },
            { Platform.VN2,  Region.SEA }
        };

        public static Region GetRegionFromPlatform(Platform platform)
        {
            if (PlatformRegionPairs.TryGetValue(platform, out Region region))
            {
                return region;
            }
            else
            {
                throw new ArgumentException($"No matching region found for platform: {platform}");
            }
        }
    }
}