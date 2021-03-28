package main

import (
	"fmt"
	"simple-microservices/services/clock/internal"
)

func main() {
	fmt.Println("Hello")
	cs := internal.NewService()
	cs.Start()
	defer cs.Stop()
}
