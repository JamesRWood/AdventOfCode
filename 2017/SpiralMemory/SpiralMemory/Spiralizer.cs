namespace SpiralMemory
{
    using System.Collections.Generic;

    public class Spiralizer
    {
        private readonly Dictionary<int, (int xCoord, int yCoord)> _blockDataStore;
        private Direction _direction;

        public Spiralizer()
        {
            _blockDataStore = new Dictionary<int, (int xCoord, int yCoord)>();
        }

        public int GetSteps(int blockLocation)
        {
            ConstructDataSpiral(blockLocation);

            return _blockDataStore[blockLocation].xCoord + _blockDataStore[blockLocation].yCoord;
        }

        private void ConstructDataSpiral(int blockLocation)
        {
            for (var i = 1; i <= blockLocation; i++)
            {
                if (i == 1)
                {
                    _blockDataStore.Add(i, (0, 0));
                    _direction = GetNextDirection(_direction);
                    continue;
                }

                var lastEntry = _blockDataStore[i - 1];
                var xCoord = lastEntry.xCoord;
                var yCoord = lastEntry.yCoord;

                if (_direction == Direction.Right || _direction == Direction.Left)
                {
                    xCoord = MoveOnAxis(xCoord);
                }

                if (_direction == Direction.Up || _direction == Direction.Down)
                {
                    yCoord = MoveOnAxis(yCoord);
                }

                _blockDataStore.Add(i, (xCoord, yCoord));
                _direction = GetNextDirection(_direction);
            }
        }

        private int MoveOnAxis(int currentCoord)
        {
            return _direction == Direction.Up || _direction == Direction.Right ? currentCoord + 1 : currentCoord - 1;
        }

        private Direction GetNextDirection(Direction currentDirection)
        {
            return currentDirection == Direction.NotSet ? Direction.Up : 
                   currentDirection == Direction.Up ? Direction.Left : 
                   currentDirection == Direction.Left ? Direction.Down : 
                   currentDirection == Direction.Down ? Direction.Right : 
                   Direction.Up;
        }
    }
}
