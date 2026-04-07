namespace MyApp.Delegates;




public class ValueChanger
{
public delegate int ChangeValue(int value);
  public static int Square(int x) => x * x;
  public int Cube(int x) => x * x * x;


public void Transform(int[] values, ChangeValue t)
    {
        for(int i = 0; i < values.Length; i++)
        {
            values[i] = t(values[i]);
        }
    }

}