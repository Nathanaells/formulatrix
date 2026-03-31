 class Program
   {
       static void Main(string[] args)
       {
          Foobar(15);
       }

static void Foobar(int number)
    {
    for(int i = 1; i <= number; i++)
        {
            if(i >= 3 && i >= 5 && i % 3 == 0 && i % 5 == 0)
            {
            Console.WriteLine("foobar");
            }else if(i >= 3 && i % 3 == 0){
                Console.WriteLine("foo");
            }else if(i >= 5 && i % 5 == 0)
            {
                Console.WriteLine("bar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
   }