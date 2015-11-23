using System;

namespace Rover
{
    public class RoverObject
    {
        public RoverObject(CoOrdinates currentPosition, Direction currentDirection, Plateau plateau)
        {
            CurrentDirection = currentDirection;
            CurrentPosition = currentPosition;
            Plateau = plateau;
        }

        public CoOrdinates CurrentPosition { get; private set; }
        public Direction CurrentDirection { get; set; }
        public Plateau Plateau { get; private set; }

        public void LeftTurn()
        {
            CurrentDirection = CurrentDirection.OneStepLeft();
        }

        public void RightTurn()
        {
            CurrentDirection = CurrentDirection.OneStepRight();
        }

        public void MoveOneStep()
        {
            var newPosition = CurrentPosition.MoveToNewPosition(CurrentDirection);
            if (Plateau.IsInBound(newPosition))
                CurrentPosition = newPosition;
            else
                Console.WriteLine("Skipping command as it is crossing plateau bound");
        }

        public void Run(string commandString)
        {
            foreach (var command in CommandParser.StringToCommands(commandString))
            {
                command.Execute(this);
                Console.WriteLine(this);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}", CurrentPosition, CurrentDirection.ToStringDirection());
        }
    }
}