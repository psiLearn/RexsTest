#r "nuget: FSharp.Data"
#r "System.Xml.Linq.dll"
open FSharp.Data

[<Literal>]
let FName = __SOURCE_DIRECTORY__ + "/FVA_Shaft-with-additional-mass.rexs"
type RexsExample = XmlProvider<FName>
let sample = RexsExample.GetSample()

sample.Components