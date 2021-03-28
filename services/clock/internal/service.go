package internal

import "fmt"

type clockService struct{}

func NewService() *clockService {
	//setup grpc server
	cs := &clockService{}
	return cs
}

func (cs *clockService) Start() {
	fmt.Println("Started")
}
func (cs *clockService) Stop() {
	fmt.Println("Stopped")
}
