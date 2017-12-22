namespace JumpMaze
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MazeJumper
    {
        private List<int> _instructions;
        private int _numberOfMoves = 0;
        private int _result;
        private int _currentPosition = 0;
        private bool _escaped = false;

        public int Jump(string input)
        {
            ParseInput(input);
            Execute();

            return _result;
        }

        private void Execute()
        {
            try
            {
                while (!_escaped)
                {
                    var currentInstruction = _instructions[_currentPosition];

                    if (currentInstruction == 0)
                    {
                        UpdatePositionAndMoves();
                    }
                    else if (currentInstruction > 0 && currentInstruction < 3)
                    {
                        UpdatePositionAndMoves();
                        _currentPosition = _currentPosition + currentInstruction;
                    }
                    else if (currentInstruction >= 3)
                    {
                        _instructions[_currentPosition]--;
                        _numberOfMoves++;
                        _currentPosition = _currentPosition + currentInstruction;
                    }
                    else if (currentInstruction < 0)
                    {
                        UpdatePositionAndMoves();
                        _currentPosition = _currentPosition - Math.Abs(currentInstruction);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                _result = _numberOfMoves;
            }
        }

        private void UpdatePositionAndMoves()
        {
            _instructions[_currentPosition]++;
            _numberOfMoves++;
        }
        
        private void ParseInput(string input)
        {
            _instructions = new List<int>();
            input.Split(null).Where(x => !string.IsNullOrEmpty(x)).ToList().ForEach(x => _instructions.Add(int.Parse(x)));
        }
    }
}
