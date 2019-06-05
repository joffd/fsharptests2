``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1620 v3 3.50GHz, 1 CPU, 8 logical and 4 physical cores
Frequency=3410126 Hz, Resolution=293.2443 ns, Timer=TSC
.NET Core SDK=3.0.100-preview5-011568
  [Host]     : .NET Core 3.0.0-preview5-27626-15 (CoreCLR 4.6.27622.75, CoreFX 4.700.19.22408), 64bit RyuJIT DEBUG  [AttachedDebugger]
  DefaultJob : .NET Core 3.0.0-preview5-27626-15 (CoreCLR 4.6.27622.75, CoreFX 4.700.19.22408), 64bit RyuJIT


```
| Method |      Mean |     Error |   StdDev |      Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |----------:|----------:|---------:|-----------:|------:|------:|----------:|
| Matrix |  34.58 ms | 0.6510 ms | 1.401 ms |          - |     - |     - |   76.3 MB |
| Tensor | 205.44 ms | 4.1927 ms | 6.013 ms | 45000.0000 |     - |     - | 305.18 MB |
