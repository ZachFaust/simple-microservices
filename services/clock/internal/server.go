package internal

import (
	pb "simple-microservices/lib/proto/clock"
)

type server struct{}

func (s server) CurrentTime(req pb.CurrentTimeRequest, srv pb.ClockService_CurrentTimeServer) error {
	return nil
}
