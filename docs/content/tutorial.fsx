(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
Introducing your project
========================

Say more

*)
#r "FSharp.AsyncBuilderExtensions.dll"
open FSharp.Control
open System.Threading.Tasks

async { 
    let! x = Task.Run(fun () -> Console.WriteLine())
}

(**
Some more info
*)
