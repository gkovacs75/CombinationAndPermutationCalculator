namespace CombinationAndPermutationCalculator
{
    public static class Helpers
    {
        internal static int Factorial(int i)
        {
            int result = i < 0 ? -1 : i == 0 || i == 1 ? 1 : 1;

            if (i > 0)
            {
                Enumerable.Range(1, i).ToList<int>().ForEach(element => result = result * element);
            }

            return result;
        }
    }
}
