class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        foreach (ITile tile in board._tiles)
        {
            Console.WriteLine(tile.Point.GetPoint());
        }
    }
}

class Board
{
    public ITile[] _tiles;

    public Board()
    {
        generateTiles();
    }

    public void generateTiles()
    {
        _tiles = new ITile[40];
        for (int i = 0; i < 40; i++)
        {
            _tiles[i] = new RentTile($"Tile {i}", new Point(i, 0));
        }
    }

    public ITile GetTileAt(ITile tile)
    {
        return tile;
    }
}

class Player
{
    private int _id;
    private string _name;
    public int DoubleCount;
    public Piece piece;
    public bool IsInJail;
    public int JailTurn;
    public bool IsBankrupt;

    public Player(int id, string name)
    {
        _id = id;
        _name = name;
    }
}

class Piece
{
    public PieceType PieceType;

    public Piece(PieceType pieceType)
    {
        PieceType = pieceType;
    }
}

enum PieceType
{
    TopHat,
    Car,
    ScottieDog,
    Horse,
    Battleship,
    Thimble,
    Cannon,
}

interface ITile
{
    public string Name { get; set; }
    public Point Point { get; }

    public void OnPlayerLanded() { }
}

class RentTile : ITile
{
    public string Name { get; set; }
    public Point Point { get; set; }

    public int Price;
    public int Houses;
    public bool HasHotel;

    PropertyCity city;
    PropertyColor color;

    public RentTile(string name, Point point)
    {
        this.Name = name;
        this.Point = point;
    }
}

enum PropertyCity
{
    MediterraneanAvenue,
    BalticAvenue,
    BoardWalk,
    ParkPlace,
}

enum PropertyColor
{
    Brown,
    LightBlue,
    Pink,
    Orange,
    Red,
    Yellow,
    Green,
    DarkBlue,
}

public struct Point
{
    public int x;
    public int y;

    public (int, int) GetPoint()
    {
        return (x, y);
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
