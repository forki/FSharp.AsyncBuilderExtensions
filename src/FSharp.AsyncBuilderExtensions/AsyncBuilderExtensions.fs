namespace FSharp.Control

[<AutoOpen>]
module AsyncBuilderExtensions =

    type AsyncBuilder with
        member __.Bind(task : System.Threading.Tasks.Task<'a>, f : 'a -> Async<'b>) =
            let task = task |> Async.AwaitTask
            async.Bind(task, f)

        member __.Bind(task : System.Threading.Tasks.Task, f : unit -> Async<unit>) =
            let task = task |> Async.AwaitTask
            async.Bind(task, f)
