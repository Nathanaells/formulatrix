public class FoobarGenerator
{
    public Dictionary<int, string> Rules;

    public FoobarGenerator(Dictionary<int, string> rules)
    {
        Rules = rules;
    }

    public bool AddRule(int input, string output)
    {
        if (Rules.ContainsKey(input))
        {
            Console.WriteLine($"Rules bagi {input} sudah ada dengan output {Rules[input]}.");
            Console.WriteLine("--------------------------------------------------------------");
            return false;
        }

        Rules.Add(input, output);
        return true;
    }

    public bool RemoveRule(int input)
    {
        if (!Rules.ContainsKey(input))
        {
            Console.WriteLine($"Rules bagi {input} tidak ditemukan.");
            Console.WriteLine("--------------------------------------------------------------");
            return false;
        }
        Rules.Remove(input);
        return true;
    }

    public static string[] PrintFoobar(Dictionary<int, string> rules, int number)
    {
        string[] results = new string[number];

        for (int i = 1; i <= number; i++)
        {
            string temp = "";

            foreach (var rule in rules)
            {
                if (i % rule.Key == 0)
                {
                    temp += rule.Value;
                }
            }

            if (temp == "")
            {
                results[i - 1] = i.ToString();
            }
            else
            {
                results[i - 1] = temp;
            }
        }

        return results;
    }
}
