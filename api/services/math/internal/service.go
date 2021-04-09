package internal

import (
	"fmt"
	"log"
	"net"

	pb "api/lib/proto/math"

	"google.golang.org/grpc"
)

type mathService struct{}

func NewService() *mathService {
	//setup grpc server
	cs := &mathService{}
	return cs
}

func (cs *mathService) Start() {
	fmt.Println("Started")
	lis, err := net.Listen("tcp", fmt.Sprintf("localhost:%s", grpcPort))
	if err != nil {
		log.Fatalf("failed to listen: %v", err)
	}
	var opts []grpc.ServerOption
	grpcServer := grpc.NewServer(opts...)
	pb.RegisterMathServiceServer(grpcServer, newServer())
	grpcServer.Serve(lis)
}
func (cs *mathService) Stop() {
	fmt.Println("Stopped")
}
