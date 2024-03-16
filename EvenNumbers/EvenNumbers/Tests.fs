open Program
open FsCheck

let evenNumberTest list = 
    getAmountOfEvenNumbersByMapFunction list  = getAmountOfEvenNumbersByFilterFunction list &&
    getAmountOfEvenNumbersByFilterFunction list = getAmountOfEvenNumbersByFoldFunction list &&
    getAmountOfEvenNumbersByFoldFunction list = getAmountOfEvenNumbersByMapFunction list
    
Check.Quick evenNumberTest