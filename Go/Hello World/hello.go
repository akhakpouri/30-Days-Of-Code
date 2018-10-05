package main

import (
	"fmt"
)

func main() {
	fmt.Printf("Welcome to GO. \n")
	beyondHello()
}

func beyondHello() {
	var x int
	x = 3
	y := 4
	sum, prod := learnMultiple(x, y)
	fmt.Println("sum:", sum, "prod:", prod)
}

/*
I'm expecting `x` and `y` as argumnents and `sum` and `prod` are being returned. Eventhough those are in the signature.
I can define the type only once if all arguments are the same.
*/
func learnMultiple(x, y int) (sum int, prod float32) {
	return x + y, float32(float32(x*y) * float32(1.2)) //Returns two values here. One for sum, one for prod
}
