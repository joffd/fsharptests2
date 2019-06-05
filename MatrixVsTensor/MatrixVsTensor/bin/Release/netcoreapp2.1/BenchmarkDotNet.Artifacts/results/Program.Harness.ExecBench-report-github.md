``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1620 v3 3.50GHz, 1 CPU, 8 logical and 4 physical cores
Frequency=3410097 Hz, Resolution=293.2468 ns, Timer=TSC
.NET Core SDK=2.1.700
  [Host]     : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT DEBUG  [AttachedDebugger]
  DefaultJob : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT


```
| Method |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |----------:|----------:|----------:|------:|------:|------:|----------:|
| Matrix | 99.917 ms | 0.0533 ms | 0.0498 ms |     - |     - |     - |         - |
| Tensor |  9.990 ms | 0.0028 ms | 0.0026 ms |     - |     - |     - |         - |
