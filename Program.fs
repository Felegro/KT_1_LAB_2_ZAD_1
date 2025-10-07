let numbers = [123; 45; 6789; 12]

let getProductOfDigits (num : int) =
    num.ToString()
    |> Seq.map (fun c -> int c - int '0')
    |> Seq.fold (*) 1

let products = List.map getProductOfDigits numbers

printfn "Исходный список цифр: %A" numbers
printfn "Список произведений цифр: %A" products