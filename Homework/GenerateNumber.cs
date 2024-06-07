namespace RandomGenerator;

public class GenerateNumber 
{
   public int genNumber()
   {
        Random random = new Random();
        return random.Next(maxValue: int.MaxValue, minValue: int.MinValue); 
   }

   public int genNumber(int value)
    {
        Random random = new Random();
        return random.Next(value);
    }
}
