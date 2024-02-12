module Assignment2

    //Exercise 2.1 Write a function downto1 : int -> int list that given an integer n returns the n-element list [n; n-1; ...; 1] if
    //n > 0 and [] otherwise. You must use if-then-else expressions to define the function.
    let downto1 (n:int) =
        if n = 0 then []
        else [n .. -1 .. 1]
    
    //Secondly define the function downto2 having same semantics as downto1. This time you must use pattern matching.
    let downto2 (n:int) =
        match n with
        | 0 -> []
        | _ -> [n .. -1 .. 1]

    //Exercise 2.2 - Write a function removeOddIdx : 'a list -> 'a list that given a list xs returns a list where all odd-indexed
    //elements of xs have been removed.
    let rec removeOddIdx xs =
        match xs with
        | [] -> []
        | [x] -> [x]
        | y :: _ :: ys -> y :: removeOddIdx ys

    // Exercise 2.3 - Write a function combinePair : 'a list -> ('a * 'a) list that given a list xs returns the list with elements from xs
    // combined into pairs. If xs contains an odd number of elements, then the last element is thrown away.
    let rec combinePair xs =
        match xs with
        | [] -> []
        | [_] -> []
        | x :: y :: ys -> (x, y) :: combinePair ys

    // Exercise 2.4 - The set of complex numbers is the set of pairs of real numbers.
    // Define a type 'complex' that represents complex numbers with floating point components.
    type complex = {real : float; imaginary : float}
    
    //Define a function mkComplex : float -> float -> complex that given two floating point numbers return the corresponding complex number.
    let mkComplex (a:float) (b:float) : complex =
        {
        real = a
        imaginary = b
        }
    
    //Define a function complexToPair : complex -> float * float that given a complex number (a,b) returns the pair (a, b).
    let complexToPair (complexNumber : complex) : float * float =
        (complexNumber.real, complexNumber.imaginary)
        
    // Declare an infix function |+| of type complex -> complex -> complex for addition of complex numbers
    let (|+|) (fst : complex) (snd : complex) : complex =
        {
            real = fst.real + snd.real
            imaginary = fst.imaginary + snd.imaginary
        }
    
    // Declare an infix function |*| of type complex -> complex -> complex for multiplication of complex numbers
    let (|*|) (fst : complex) (snd : complex) : complex =
        {
            real = (fst.real * snd.real) - (fst.imaginary * snd.imaginary)
            imaginary = (fst.imaginary * snd.real) + (fst.real * snd.imaginary)
        }
    
    // Declare an infix function |-| of type complex -> complex -> complex for subtraction of complex numbers.
    let (|-|) (fst : complex) (snd : complex) : complex =
        fst |+| {
            real = -snd.real
            imaginary = -snd.imaginary
        }
        
    // Declare an infix function |/| of type complex -> complex -> complex for subtraction of complex numbers.
    let (|/|) (fst : complex) (snd : complex) : complex =
        let denominator = snd.real ** 2 + snd.imaginary ** 2
        if denominator = 0.0 then failwith "Denominator is 0.0, and cant be divided by"
        else
            fst |*| {
            real = snd.real / denominator
            imaginary = -snd.imaginary / denominator
        }

    // Exercise 2.5 - Write a non-recursive function explode1 : string -> char list that given a string s returns the
    // list of characters in s
    let explode1 (s : string) : char list =
        List.ofArray(s.ToCharArray())
        
    // Write a recursive function explode2 : string -> char list that behaves the same as explode1
    let rec explode2 (s : string) : char list =
        match s with
            | "" -> []
            | _ -> s.[0] :: explode2 (s.Remove(0, 1))

    // Exercise 2.6 - Write a function implode : char list -> string that given a list of characters cs returns a string
    // with all characters of cs in the same order.
    let implode (cs : char list) : string =
        List.foldBack (fun current acc -> (string current + acc)) cs ""
 
    //Write a function implodeRev : char list -> string that given a list of characters cs returns a string with all characters of
    //cs in reverse order. You may not use List.rev for this exercise.
    let implodeRev (cs : char list) : string =
        List.fold (fun acc current -> string current + acc) "" cs

    //Exercise 2.7 - Write a function toUpper : string -> string that given a string s returns s with all characters in upper case.
    let toUpper (s : string) : string =
        s |> explode1 |> List.map System.Char.ToUpper |> implode

    // Exercise 2.8 - The Ackermann function is a recursive function where both value and number of mutually recursive calls grow rapidly.
    // Write the function ack : int * int -> int that given an integer pair (m, n) implements the Ackermann function
    let rec ack (m, n) =
        if m < 0 || n < 0 then
            failwith "The function is not defined for negative arguments"
        else
            match (m, n) with
            | (0, n) -> n + 1
            | (m, 0) -> ack (m - 1, 1)
            | (m, n) -> ack (m - 1, ack (m, n - 1))

    let downto3 _ = failwith "not implemented"

    let fac _ = failwith "not implemented"
    let range _ = failwith "not implemented"

    type word = (char * int) list


    let hello = [] // Fill in your answer here

    type squareFun = (char * int) list -> int -> int -> int

    let singleLetterScore _ = failwith "not implemented"
    let doubleLetterScore _ = failwith "not implemented"
    let tripleLetterScore _ = failwith "not implemented"

    let doubleWordScore _ = failwith "not implemented"
    let tripleWordScore _ = failwith "not implemented"

    type square = (int * squareFun) list


    let oddConsonants _ = failwith "not implemented"
    
    

    let SLS : square = [(0, singleLetterScore)]
    let DLS : square = [(0, doubleLetterScore)]
    let TLS : square = [(0, tripleLetterScore)]

    let DWS : square = SLS @ [(1, doubleWordScore)]
    let TWS : square = SLS @ [(1, tripleWordScore)]

    let calculatePoints _ = failwith "not implemented"