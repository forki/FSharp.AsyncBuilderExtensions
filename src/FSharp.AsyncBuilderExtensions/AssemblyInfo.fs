namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.AsyncBuilderExtensions")>]
[<assembly: AssemblyProductAttribute("FSharp.AsyncBuilderExtensions")>]
[<assembly: AssemblyDescriptionAttribute("Extenions to the AsyncBuilder to allow Tasks to be used in an async block")>]
[<assembly: AssemblyVersionAttribute("0.0.2")>]
[<assembly: AssemblyFileVersionAttribute("0.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.2"
    let [<Literal>] InformationalVersion = "0.0.2"
