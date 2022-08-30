using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmInterface
{
    public static class IntExtensionMethods
    {
        public static TEnum ToDirectionEnum<TEnum>(this int value)
        {
            if (typeof(TEnum).IsEnumDefined(value))
                return (TEnum)(object)value;

            return default;
        }
    }
}

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}