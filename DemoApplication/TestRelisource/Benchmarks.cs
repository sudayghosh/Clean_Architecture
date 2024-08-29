using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRelisource
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        [Benchmark]
        public void Scenario1()
        {
            // Implement your benchmark here
        }

        [Benchmark]
        public void Scenario2()
        {
            // Implement your benchmark here
        }

        [Benchmark(Baseline = true)]
        public List<string> NewList()
        {
            return new List<string> { "Benchmark", "your", "code" };
        }

        [Benchmark]
        public List<string> CollExpressions()
        {
            return ["Benchmark", "your", "code"];
        }
    }
}
