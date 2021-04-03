package main

import (
	"api/services/clock/internal"
	"fmt"
)

func main() {
	fmt.Println("Hello")
	cs := internal.NewService()
	cs.Start()
	defer cs.Stop()
}
