public class Proram
{
    public static void Main(string[] args)
    {
        Note B = new Note(2);
        Note C = new Note(10);
        Note A = B;
        A += C;

        Console.WriteLine(A.getValue());
    }
}

public struct Note
{
    private int value;

    public int getValue()
    {
        return value;
    }

    public Note(int semiTonesFromA)
    {
        value = semiTonesFromA;
    }

    public static Note operator +(Note x, Note semitones)
    {
        return new Note(x.value + semitones.value);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
