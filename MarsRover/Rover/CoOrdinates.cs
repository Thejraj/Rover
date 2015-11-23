// -----------------------------------------------------------------------
// <copyright file="CoOrdinates.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Rover
{
    /// <summary>
    ///     TODO: Update summary.
    /// </summary>
    public class CoOrdinates
    {
        public CoOrdinates(int xCoOrdinate, int yCoOrdinate)
        {
            XCoOrdinate = xCoOrdinate;
            YCoOrdinate = yCoOrdinate;
        }

        public int XCoOrdinate { get; private set; }
        public int YCoOrdinate { get; private set; }

        public CoOrdinates MoveToNewPosition(Direction direction)
        {
            switch (direction)
            {
                case Direction.N:
                    YOneStepAhead();
                    break;
                case Direction.E:
                    XOneStepAhead();
                    break;
                case Direction.S:
                    YOneStepBehind();
                    break;
                case Direction.W:
                    XOneStepBehind();
                    break;
                default:
                    break;
            }

            return this;
        }

        public override string ToString()
        {
            return string.Format("Current position:\n\tX = {0}\n\tY = {1}", this.XCoOrdinate, this.YCoOrdinate);
        }

        private void XOneStepAhead()
        {
            XCoOrdinate += 1;
        }

        private void YOneStepAhead()
        {
            YCoOrdinate += 1;
        }

        private void XOneStepBehind()
        {
            XCoOrdinate -= 1;
        }

        private void YOneStepBehind()
        {
            YCoOrdinate -= 1;
        }
    }
}