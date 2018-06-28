// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let fizzBuzz number = 
    match number with
    | _ when number % 15 = 0 -> "fizzbuzz"
    | _ when number % 3 = 0 -> "fizz"
    | _ when number % 5 = 0 -> "buzz"
    | _ -> string number


[<EntryPoint>]
let main argv = 

    let stopWatch = new System.Diagnostics.Stopwatch()

    stopWatch.Start()

    for i in [1..1000] do
        printfn "%s" (fizzBuzz i)

    stopWatch.Stop()
    printfn "Elapsed Time: %i" stopWatch.ElapsedMilliseconds

    printfn "Press any key to continue."
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
