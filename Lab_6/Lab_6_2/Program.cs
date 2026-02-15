using System;
namespace Lab6
{
    abstract class ChessPiece
    {
        protected int x;
        protected int y;
        public ChessPiece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract bool CanMove(int nx, int ny);
    }
    class King : ChessPiece
    {
        public King(int x, int y) : base(x, y) { }
        public override bool CanMove(int nx, int ny)
        {
            int dx = Math.Abs(nx - x);
            int dy = Math.Abs(ny - y);
            return dx <= 1 && dy <= 1;
        }
    }
    class Knight : ChessPiece
    {
        public Knight(int x, int y) : base(x, y) { }
        public override bool CanMove(int nx, int ny)
        {
            int dx = Math.Abs(nx - x);
            int dy = Math.Abs(ny - y);
            return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
        }
    }
    class Pawn : ChessPiece
    {
        public Pawn(int x, int y) : base(x, y) { }
        public override bool CanMove(int nx, int ny)
        {
            return nx == x && ny == y + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChessPiece[] pieces =
            {
                new King(4, 4),
                new Knight(4, 4),
                new Pawn(4, 4)
            };

            foreach (ChessPiece p in pieces)
            {
                Console.WriteLine(p.CanMove(5, 5));
            }
        }
    }
}