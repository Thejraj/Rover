// -----------------------------------------------------------------------
// <copyright file="CommandParser.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Rover.Command;

namespace Rover
{
    /// <summary>
    ///     TODO: Update summary.
    /// </summary>
    public class CommandParser
    {
        private static readonly Dictionary<char, ICommand> CommandMap = new Dictionary<char, ICommand>
        {
            {'L', new LeftTurnCommand()},
            {'R', new RightTurnCommand()},
            {'M', new MoveCommad()}
        };

        public static List<ICommand> StringToCommands(string commandString)
        {
            var commands = new List<ICommand>();
            foreach (var command in commandString.ToCharArray())
            {
                commands.Add(CommandMap.FirstOrDefault(c => c.Key == command).Value);
            }

            return commands;
        }
    }
}