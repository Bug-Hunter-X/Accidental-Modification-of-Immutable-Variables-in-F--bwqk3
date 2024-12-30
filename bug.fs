let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 as expected

//However, if we try to swap immutable values, it will not work.
let x1 = 10
let y1 = 20

let swap1 x y = 
    let temp = x
    x <- y // This will throw an error since x is immutable
    y <- temp

swap1 x1 y1 // This will cause an error