``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1620 v3 3.50GHz, 1 CPU, 8 logical and 4 physical cores
Frequency=3410126 Hz, Resolution=293.2443 ns, Timer=TSC
.NET Core SDK=3.0.100-preview5-011568
  [Host] : .NET Core 2.1.11 (CoreCLR 4.6.27617.04, CoreFX 4.6.27617.02), 64bit RyuJIT DEBUG  [AttachedDebugger]


```
|    Method | Mean | Error |
|---------- |-----:|------:|
|    Matrix |   NA |    NA |
| TensorCPU |   NA |    NA |
| TensorGPU |   NA |    NA |

Benchmarks with issues:
  ExecBench.Matrix: DefaultJob
  ExecBench.TensorCPU: DefaultJob
  ExecBench.TensorGPU: DefaultJob
