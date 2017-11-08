namespace AlgortGeneral
{
	public class FibonanciRafa
	{
		public static int CalcFibonanci(int n)
		{
			if (n == 0) return 0;
			if (n == 1) return 1;
			return CalcFibonanci(n - 1) + CalcFibonanci(n - 2);
		}
	}
}
