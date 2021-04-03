package main

import (
	"context"
	"fmt"
	"io"

	pb "simple-microservices/lib/proto/clock"

	"google.golang.org/grpc"
)

func main() {
	address := "localhost:8080"
	var opts []grpc.DialOption
	opts = append(opts, grpc.WithInsecure())
	conn, err := grpc.Dial(address, opts...)
	if err != nil {
		fmt.Println(err)
	}
	defer conn.Close()
	client := pb.NewClockServiceClient(conn)
	stream, err := client.CurrentTime(context.Background(), &pb.CurrentTimeRequest{})
	if err != nil {
		return
	}
	for {
		time, err := stream.Recv()
		if err == io.EOF {
			break
		}
		if err != nil {
			fmt.Printf("%v.CurrentTime(_) = _, %v", client, err)
		}
		fmt.Println(time.GetTime().AsTime().String())
	}

}
