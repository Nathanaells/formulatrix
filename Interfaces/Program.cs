class Program
{
    static void Main(string[] args)
    {
        @IEnumerator e = new Countdown();
        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }
    }
}

public interface @IEmumerator
{
    bool MoveNext();
    object Current {get; set;}
    void Reset();
}

internal class Countdown : @IEmumerator
{
    int count = 11;
    public bool MoveNext () => count-- > 0;
    public object Current {set => throw new NotSupportedException(); get => count;}
    public void Reset() => throw new NotSupportedException();

     

}