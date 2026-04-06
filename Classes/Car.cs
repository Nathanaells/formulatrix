namespace Classes
{
    public class Foo
    {
        private decimal x;
        public decimal X
        {
            get { return x;}
            
            private set
            {
                x = Math.Round(value, 2);
            }
        }
    }   
    
}