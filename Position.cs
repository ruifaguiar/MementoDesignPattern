namespace MementoDesignPattern
{
    public class Position
    {
        private int _x;
        private int _y;
        private int _z;
        public Position(int x, int y, int z)
        {
            Original = new PositionMemento();
            X = x;
            Y = y;
            Z = z;

        }
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Original.X = _x;
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Original.Y = _y;
                _y = value;
            }
        }

        public int Z
        {
            get
            {
                return _z;
            }
            set
            {
                Original.Z = _z;
                _z = value;
            }
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";

        }

        private PositionMemento Original { get; set; }

        private class PositionMemento
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

        }

        public void Revert()
        {
            _x = Original.X;
            _y = Original.Y;
            _z = Original.Z;
        }

        public bool IsDirty
        {
            get
            {
                return X != Original.X || Y != Original.Y || Z != Original.Z;
            }
        }


    }
}