module Assignment2

    let downto1 _ = failwith "not implemented"
    
    let downto2 _ = failwith "not implemented"

    let removeOddIdx _ = failwith "not implemented"

    let combinePair _ = failwith "not implemented"


    type complex = unit // Fill in your type here
    let mkComplex _ = failwith "not implemented"
    let complexToPair _ = failwith "not implemented"
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