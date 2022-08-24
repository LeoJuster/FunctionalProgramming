open System
open FSharp.Data
open System.Net
open System.IO

//Question 1
let cube()=
    // This function cubes a certain entered parameter
    let get_sum (cube : int) : int = cube*cube*cube
    printfn "5 cubed =%i" (get_sum(5))


cube()

Console.ReadKey() |> ignore


// Question 2
let cost num  =
    if num >= 100 then "Expensive" //Displayed when cost is expensive
    elif (num < 100 && num > 50) then "Good Value"//Displayed when cost is good value
    elif num <= 50 then "Bargain"//Displayed when cost is a baragin
    else "zero"

let main() =
    Console.Write("Please enter the cost here:")//allows user to enter cost
    let input = Console.ReadLine()
    Console.Write("The number {0}", cost 1)//returns value of cost
    System.Console.ReadKey() |> ignore

main()


// Question 3
let tuple()=
    let sum (x, y) : float =
        let get_sum = x+y //This si the additionof x and y together
        get_sum * -1.0 //here we multiply the value from the get_sum by -1
    printfn "Answer: %f" (sum(14.0, 26.0))//contains the values of X and Y
tuple()
Console.ReadKey() |> ignore


//Question 4
let fiveTimesTable()=
    // Produces a list of the 5 times table, with 100 values
    let list1 = Seq.init 100 (fun n -> n * 5)
    Seq.iter (fun elem -> printf "%d " elem) list1

fiveTimesTable()
Console.ReadKey() |> ignore



//Question 5
let tens()=
    // Yeild a list of 10s from upper and lower values
    let list1 = [ for a in 0..100 do if a % 10 = 0 then yield a]
    printfn "%A" list1

tens()
Console.ReadKey() |> ignore