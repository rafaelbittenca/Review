namespace AlgortGeneral
{
	/// <summary>
	/// In mathematics, the Fibonacci numbers are the numbers in the following integer sequence, called the Fibonacci
	/// sequence, and characterized by the fact that every number after the first two is the sum of the two preceding ones
	/// 1,1,2,3,5,8,13,21,34,55,89,144...
	/// Often, especially in modern usage, the sequence is extended by one more initial term:
	/// 0,1,1,2,3,5,8,13,21,34,55,89,144...
	/// </summary>
	public static class FibonacciNumber
    {

        public static int CalculateFibonacci(int myNumber)
        {
            int number = myNumber - 1;                 //Need to decrement by 1 since we are starting from 0
            int[] arrayFib = new int[number + 1];
            arrayFib[0] = 0;
            arrayFib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                arrayFib[i] = arrayFib[i - 2] + arrayFib[i - 1];
            }
            return arrayFib[number];
        }

        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
    }
}
