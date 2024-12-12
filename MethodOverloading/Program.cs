namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne,int numTwo,bool isMoney)
        {
            var sum = numOne + numTwo;

            if(isMoney && sum > 1)
            {
                return $"{sum} Dollars.";
            }
            else if(isMoney && sum == 1)
            {
                return $"{sum} Dollar.";
            }
            else
            {
                return sum.ToString();
            }
        }    
                
          static void Main(string[] args)
        {
            var x = 5;
            var y = 7;

            var Answer = Add(x, y);

            var a = 13.1m;
            var b = 20.2m;

            var decimalAnswer = Add(a, b);

            var ThirdAnswer = Add(2, 4, true);

            Console.WriteLine($"Answers:\n int Add: {Answer}\n Decimal Add: {decimalAnswer}\n is money: {ThirdAnswer}");



           
        }     
                 
                
            
        

        
    }
}
