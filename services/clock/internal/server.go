package internal

import (
	pb "simple-microservices/lib/proto/clock"
	"time"

	timestamppb "google.golang.org/protobuf/types/known/timestamppb"
)

type server struct {
	pb.UnimplementedClockServiceServer
}

func newServer() *server {
	return &server{}
}

func (s server) CurrentTime(req *pb.CurrentTimeRequest, srv pb.ClockService_CurrentTimeServer) error {
	t := time.NewTicker(time.Second * 1)
	defer t.Stop()
	for {
		select {
		case <-t.C:
			if err := srv.Send(getCurrentTime()); err != nil {
				return err
			}
		case <-srv.Context().Done():
			return nil
		}
	}
}

func getCurrentTime() *pb.Time {
	return &pb.Time{
		Time: timestamppb.Now(),
	}
}
