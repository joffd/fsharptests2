

module MatrixVsTensor

    open MathNet.Numerics.LinearAlgebra
    open Tensor


    let sigmoid x = 1. / (1. + exp(-x))
    let rnd = System.Random()
    let a1 = Array.init 10000000 (fun _ -> rnd.NextDouble())
    let t1 = HostTensor.ofArray a1
    let m1 = CreateVector.DenseOfArray a1

    let t1sig() = t1 |> HostTensor.map sigmoid
    let m1sig() = m1 |> Vector.map sigmoid


    