```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method          | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|----------:|------------:|
| Scenario1       |  0.0407 ns | 0.0291 ns | 0.0755 ns |  0.0000 ns | 0.002 |    0.00 |      - |         - |        0.00 |
| Scenario2       |  0.0454 ns | 0.0337 ns | 0.0755 ns |  0.0052 ns | 0.002 |    0.00 |      - |         - |        0.00 |
| NewList         | 24.7872 ns | 0.6305 ns | 1.7470 ns | 24.1146 ns | 1.000 |    0.00 | 0.0280 |      88 B |        1.00 |
| CollExpressions | 22.6107 ns | 1.5002 ns | 4.4234 ns | 21.7251 ns | 0.876 |    0.15 | 0.0255 |      80 B |        0.91 |
