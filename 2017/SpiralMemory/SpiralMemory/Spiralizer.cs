namespace SpiralMemory
{
    using System;
    using System.Collections.Generic;

    public class Spiralizer
    {
        private readonly Dictionary<int, (int xCoord, int yCoord)> _blockDataStore;
        private Direction _direction;

        private int _xLength = 1;
        private int _yLength = 1;
        private int _xHighest;
        private int _xLowest;
        private int _yHighest;
        private int _yLowest;
        private bool _changeDirection;

        public Spiralizer()
        {
            _blockDataStore = new Dictionary<int, (int xCoord, int yCoord)> { {1, (0, 0)} };
            _direction = Direction.Up;
            _changeDirection = false;
        }

        public int GetSteps(int blockLocation)
        {
            ConstructDataSpiral(blockLocation);

            return Math.Abs(_blockDataStore[blockLocation].xCoord) + Math.Abs(_blockDataStore[blockLocation].yCoord);
        }

        private void ConstructDataSpiral(int blockLocation)
        {
            var xCoord = 0;
            var yCoord = 0;
            for (var i = 2; i <= blockLocation; i++)
            {
                if (_changeDirection)
                {
                    _direction = GetNextDirection(_direction);
                    _changeDirection = false;
                }

                var position = GetNextPosition(xCoord, yCoord);
                xCoord = position.xCoord;
                yCoord = position.yCoord;

                _blockDataStore.Add(i, (xCoord, yCoord));

                //if (_direction == Direction.Up || _direction == Direction.Down)
                //{
                //    position.xCoord = _direction == Direction.Down ? position.xCoord + 1 : position.xCoord - 1;
                //}
                //else
                //{
                //    position.yCoord = _direction == Direction.Left ? position.yCoord - 1 : position.yCoord + 1;
                //}

                //if (_changeDirection)
                //{
                //    _direction = GetNextDirection(_direction);
                //    _changeDirection = false;
                //}

                //if (Math.Sqrt(_blockDataStore.Count) % 1 == 0)
                //{
                //    _changeDirection = true;
                //}

                //if (_blockDataStore.Count < 4 || yCoord == xCoord * -1)
                //{
                //    _direction = GetNextDirection(_direction);
                //}

                //var nextExists = _blockDataStore.Where(x => x.Value.xCoord == position.xCoord && x.Value.yCoord == position.yCoord).ToList();
                //if (nextExists.Count == 0)
                //{
                //    _direction = GetNextDirection(_direction);
                //}

                var nextTurnCoord = GetNextTurnCoords(xCoord, yCoord);
                if (nextTurnCoord.Item1 == xCoord && nextTurnCoord.Item2 == yCoord)
                {
                    _changeDirection = true;
                }
            }
        }

        private (int xCoord, int yCoord) GetNextPosition(int xCoord, int yCoord)
        {
            var x = xCoord;
            var y = yCoord;

            switch (_direction)
            {
                case Direction.Left:
                    x = x - 1;
                    if (x > _xHighest)
                    {
                        _xHighest = x;
                        _xLength = _xLength + 1;
                    }
                    else if (x < _xLowest)
                    {
                        _xLowest = x;
                        _xLength = _xLength + 1;
                    }
                    break;
                case Direction.Right:
                    x = x + 1;
                    if (x > _xHighest)
                    {
                        _xHighest = x;
                        _xLength = _xLength + 1;
                    }
                    else if (x < _xLowest)
                    {
                        _xLowest = x;
                        _xLength = _xLength + 1;
                    }
                    break;
                case Direction.Down:
                    y = y - 1;
                    if (y > _yHighest)
                    {
                        _yHighest = y;
                        _yLength = _yLength + 1;
                    }
                    else if (y < _yLowest)
                    {
                        _yLowest = y;
                        _yLength = _yLength + 1;
                    }
                    break;
                case Direction.Up:
                    y = y + 1;
                    if (y > _yHighest)
                    {
                        _yHighest = y;
                        _yLength = _yLength + 1;
                    }
                    else if (y < _yLowest)
                    {
                        _yLowest = y;
                        _yLength = _yLength + 1;
                    }
                    break;
                case Direction.NotSet:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return (x, y);
        }

        private Direction GetNextDirection(Direction currentDirection)
        {
            return currentDirection == Direction.NotSet ? Direction.Up :
                   currentDirection == Direction.Up ? Direction.Left :
                   currentDirection == Direction.Left ? Direction.Down :
                   currentDirection == Direction.Down ? Direction.Right : Direction.Up;
        }

        private (int, int) GetNextTurnCoords(int xCoord, int yCoord)
        {
            var x = xCoord;
            var y = yCoord;

            switch (_direction)
            {
                case Direction.Up:
                    y = Round((double)_yLength / 2.0);
                    break;
                case Direction.Down:
                    y = Round((double)_xLength / 2.0) * -1;
                    break;
                case Direction.Right:
                    x = Round((double)_yLength / 2.0);
                    break;
                case Direction.Left:
                    x = Round((double)_yLength / 2.0) * -1;
                    break;
            }

            return (x, y);
        }

        private int Round(double input)
        {
            if (input % 1 != 0)
            {
                return input < 0 ? Convert.ToInt32(input - 0.5) : Convert.ToInt32(input + 0.5);
            }

            return Convert.ToInt32(input);
        }
    }
}
