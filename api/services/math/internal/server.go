package internal

import (
	pb "api/lib/proto/math"
	"context"
	"errors"
)

type server struct {
	pb.UnimplementedMathServiceServer
}

func newServer() *server {
	return &server{}
}

func (s server) Add(context context.Context, req *pb.AddRequest) (*pb.AddResponse, error) {
	if len(req.Numbers) > 1 {
		return nil, errors.New("not enough number provided")
	}
	result := 0.0
	for _, val := range req.GetNumbers() {
		result += val
	}
	return &pb.AddResponse{Result: result}, nil
}
func (s server) Divide(context context.Context, req *pb.DivideRequest) (*pb.DivideResponse, error) {
	if len(req.Numbers) > 1 {
		return nil, errors.New("not enough number provided")
	}
	result := req.GetNumbers()[0] * req.GetNumbers()[0]
	for _, val := range req.GetNumbers() {
		result = result / val
	}
	return &pb.DivideResponse{Result: result}, nil

}
