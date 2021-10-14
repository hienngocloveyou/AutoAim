using System;
using System.Linq;
using ExileCore.PoEMemory.Components;
using ExileCore.PoEMemory.MemoryObjects;
using ExileCore.Shared.Enums;
using SharpDX;

namespace MadDog_AutoAim
{
    public static class Extensions
    {
        public static bool HasBuff(this Entity entity, string buff, bool contains = false)
        {
            return entity.HasComponent<ExileCore.PoEMemory.Components.Buffs>() &&
                   entity.GetComponent<ExileCore.PoEMemory.Components.Buffs>().BuffsList.Any(b => contains ? b.Name.Contains(buff) : b.Name == buff);
        }

        public static bool HaveStat(Entity entity, GameStat stat)
        {
            try
            {
                var result = entity?.GetComponent<Stats>()?.StatDictionary?[stat];
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
