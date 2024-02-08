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
    type complex = float * float
    
    //Define a function mkComplex : float -> float -> complex that given two floating point numbers return the corresponding complex number.
    let mkComplex (a:float) (b:float) : complex =
        (a, b)
    
    //Define a function complexToPair : complex -> float * float that given a complex number (a,b) returns the pair (a, b).
    let complexToPair ((a,b) : complex) : float * float =
        (a,b)
        
    
    let (|+|) _ = failwith "not implemented"
    let (|*|) _ = failwith "not implemented"
    let (|-|) _ = failwith "not implemented"
    let (|/|) _ = failwith "not implemented"

    let explode1 _ = failwith "not implemented"

    let rec explode2 _ = failwith "not implemented"

    let implode _ = failwith "not implemented"
    let implodeRev _ = failwith "not implemented"

    let toUpper _ = failwith "not implemented"

    let ack _ = failwith "not implemented"



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