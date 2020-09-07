``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  DefaultJob : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT


```
|  Method |     Mean |   Error |  StdDev | Ratio | RatioSD |
|-------- |---------:|--------:|--------:|------:|--------:|
|  Greedy | 279.3 ns | 1.19 ns | 1.06 ns |  0.96 |    0.01 |
| Dynamic | 291.5 ns | 4.90 ns | 4.58 ns |  1.00 |    0.00 |
|  Memory | 364.4 ns | 2.80 ns | 2.62 ns |  1.25 |    0.03 |
