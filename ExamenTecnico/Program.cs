using BenchmarkDotNet.Running;

namespace ExamenTecnico
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Descomentar la línea de abajo para ejecutar los benchmark de rendimiento.
            //BenchmarkRunner.Run<Benchmark.FindTheSumInArrayBenchmark>();
        }
        //Algoritmo que resuelve el problema asumiendo que los recursos son un bien preciado, valorando el tiempo de ejecución.
        //Notación O(2n) - Complejidad lineal.
        public static bool EfficientFindTheSumInArray(int[] nums, int requiredSum)
        {

            Dictionary<int, int> numsValuePair = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numsValuePair[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = requiredSum - nums[i];

                if (numsValuePair.ContainsKey(complement) && i != numsValuePair[complement])
                {
                    return true;
                }
            }
            return false;
        }
        //Algoritmo que resuelve el problema asumiendo que los recursos son ilimitados, valorando la simplicidad del código.
        //Notación O(n^2) - Complejidad cuadrática.
        public static bool InefficientFindTheSumInArray(int[] nums, int requiredSum)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == requiredSum)
                        return true;
                }
            }
            return false;
        }
    }
}
