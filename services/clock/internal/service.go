package internal

import (
	"fmt"
	"log"
	"net"

	pb "simple-microservices/lib/proto/clock"

	"google.golang.org/grpc"
)

type clockService struct{}

func NewService() *clockService {
	//setup grpc server
	cs := &clockService{}
	return cs
}

func (cs *clockService) Start() {
	fmt.Println("Started")
	lis, err := net.Listen("tcp", fmt.Sprintf("localhost:%s", grpcPort))
	if err != nil {
		log.Fatalf("failed to listen: %v", err)
	}
	var opts []grpc.ServerOption
	grpcServer := grpc.NewServer(opts...)
	pb.RegisterClockServiceServer(grpcServer, newServer())
	grpcServer.Serve(lis)
}
func (cs *clockService) Stop() {
	fmt.Println("Stopped")
}
