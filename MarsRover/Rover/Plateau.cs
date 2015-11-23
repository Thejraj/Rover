// -----------------------------------------------------------------------
// <copyright file="Plateau.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Rover
{
    /// <summary>
    ///     TODO: Update summary.
    /// </summary>
    public class Plateau
    {
        public Plateau(int topXCoOrdinate, int topYCoOrdinate) : this(topXCoOrdinate, topYCoOrdinate, 0, 0)
        {
        }

        public Plateau(int topXCoOrdinate, int topYCoOrdinate, int bottomXCoOrdinate, int bottomYCoOrdinate)
        {
            TopRightCoOrdinate = new CoOrdinates(topYCoOrdinate, topYCoOrdinate);
            BottomLeftCoOrdinate = new CoOrdinates(bottomXCoOrdinate, bottomYCoOrdinate);
        }

        public CoOrdinates TopRightCoOrdinate { get; private set; }
        public CoOrdinates BottomLeftCoOrdinate { get; private set; }

        public bool IsInBound(CoOrdinates newCoOrdinate)
        {
            return IsInLowerBount(newCoOrdinate) & IsInUpperBount(newCoOrdinate);
        }

        private bool IsInUpperBount(CoOrdinates newCoOrdinate)
        {
            return newCoOrdinate.XCoOrdinate <= TopRightCoOrdinate.XCoOrdinate &
                   newCoOrdinate.YCoOrdinate <= TopRightCoOrdinate.YCoOrdinate;
        }

        private bool IsInLowerBount(CoOrdinates newCoOrdinate)
        {
            return newCoOrdinate.XCoOrdinate >= BottomLeftCoOrdinate.XCoOrdinate &
                   newCoOrdinate.YCoOrdinate >= BottomLeftCoOrdinate.YCoOrdinate;
        }
    }
}