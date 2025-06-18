using BenchmarkDotNet.Attributes;

namespace ExamenTecnico.Benchmark
{
    public class FindTheSumInArrayBenchmark
    {
        private readonly int[] data;
        private readonly int target;
        private readonly int dataSize = 214748;

        public FindTheSumInArrayBenchmark()
        {
            data = new int[dataSize];
            HashSet<int> uniqueNumbers = new HashSet<int>();
            Random rand = new Random(42);
            while (uniqueNumbers.Count < dataSize)
            {
                uniqueNumbers.Add(rand.Next(1, int.MaxValue));
            }

            data = new List<int>(uniqueNumbers).ToArray();
            int a = data[rand.Next(data.Length)];
            int b = data[rand.Next(data.Length)];
            target = a + b;
        }

        [Benchmark]
        public void EfficientFindTheSumInArrayBenchmark()
        {
            Program.EfficientFindTheSumInArray(data, target);
        }

        [Benchmark]
        public void InefficientFindTheSumInArrayBenchmark()
        {
            Program.InefficientFindTheSumInArray(data, target);
        }
    }
}
