let x = 10
let y = 20

let swap x y = 
    (y, x)

let x1, y1 = swap x y
printf "%d %d" x1 y1 //This will print 20 10

//Alternatively, using mutable variables:
let mutable x2 = 10
let mutable y2 = 20

let swap2 x y = 
    let temp = x
    x <- y
    y <- temp

swap2 x2 y2
printf "%d %d" x2 y2 //This will print 20 10