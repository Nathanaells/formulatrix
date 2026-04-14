class Program
{
    static void Main(string[] args)
    {
    
        var dictionary = new MyDictionary<string, int>("key1", 100);
        Console.WriteLine("Before swap:");
        Console.WriteLine(dictionary.GetKeyValuePair().Key + ": " + dictionary.GetKeyValuePair().Value);    

        Console.WriteLine("After swap:");
        dictionary.setKeyValuePair("key2", 200);
        Console.WriteLine(dictionary.GetKeyValuePair().Key + ": " + dictionary.GetKeyValuePair().Value);
    }
}


public class MyDictionary<Tkey, TValue>
{
    private Tkey _key;
    private TValue _value;
        public MyDictionary(Tkey key, TValue value)
    {
        this._key = key;
        this._value = value;
    }   

   public KeyValuePair<Tkey, TValue> GetKeyValuePair()
    {
        return new KeyValuePair<Tkey, TValue>(this._key, this._value);
    }

    public KeyValuePair<Tkey, TValue> setKeyValuePair(Tkey key, TValue value)
    {
        this._key = key;
        this._value = value;
        return new KeyValuePair<Tkey, TValue>(this._key, this._value);
    }

}