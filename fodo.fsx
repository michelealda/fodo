open System.IO;

let addFn xs = File.AppendAllLines("todo.txt", xs)
let doneFn xs = File.ReadAllLines("todo.txt")
                    |> List.ofArray
                    |> List.mapi (fun i x -> if List.contains (i+1) xs then "*"+x else x)
                    |> Array.ofList

let rmFn xs = File.ReadAllLines("todo.txt")
                    |> List.ofArray
                    |> List.mapi (fun i x -> if List.contains (i+1) xs then None else Some(x) )
                    |> List.choose (id)
                    |> Array.ofList

let writeFn xs = File.WriteAllLines("todo.txt", xs) 

let xs = fsi.CommandLineArgs |> List.ofArray

match xs[1..] with
| "add" :: tail -> addFn tail
| "done" :: tail -> tail |> List.map (int) |> doneFn |> writeFn
| "rm" :: tail -> tail |> List.map (int) |> rmFn |> writeFn
| _ -> File.ReadAllLines("todo.txt")
       |> Array.iteri (fun i s -> printfn "%i. %s" (i+1) s)
