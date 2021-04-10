package main

import (
	"api/services/math/internal"
	"fmt"
)

func main() {
	fmt.Println("Hello")
	cs := internal.NewService()
	cs.Start()
	defer cs.Stop()
}
