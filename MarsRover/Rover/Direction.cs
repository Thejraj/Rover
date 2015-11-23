// -----------------------------------------------------------------------
// <copyright file="Direction.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Rover
{
    /// <summary>
    ///     TODO: Update summary.
    /// </summary>
    public enum Direction
    {
        N,
        E,
        S,
        W
    }

    public static class DirectionExtension
    {
        public static Direction StringToEnum(this Direction direction, string value)
        {
            return (Direction) Enum.Parse(typeof (Direction), value.ToUpper());
        }

        public static Direction OneStepRight(this Direction direction)
        {
            return (Direction) (((int) direction + 1)%4);
        }

        public static Direction OneStepLeft(this Direction direction)
        {
            var value = (int) direction - 1;
            if (value < 0)
                value = 3;
            return (Direction) (value%4);
        }

        public static string ToStringDirection(this Direction direction)
        {
            return string.Format("Direction : {0}", direction);
        }
    }
}