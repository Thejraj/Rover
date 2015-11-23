// -----------------------------------------------------------------------
// <copyright file="MoveCommad.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Rover.Command
{
    /// <summary>
    ///     TODO: Update summary.
    /// </summary>
    public class MoveCommad : ICommand
    {
        public void Execute(RoverObject rover)
        {
            rover.MoveOneStep();
        }
    }
}