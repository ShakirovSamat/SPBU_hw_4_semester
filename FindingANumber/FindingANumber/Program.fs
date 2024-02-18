let rec findIndex list number index =
    if list = [] then
        -1
    elif List.head list = number then
        index
    else
        findIndex (List.tail list) (number) (index + 1)

        


    
                            