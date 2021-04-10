package internal

import (
	pb "api/lib/proto/clock"
	"log"
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
	log.Println("Current Time Stream Started")
	t := time.NewTicker(time.Second * 1)
	defer t.Stop()
	for {
		select {
		case <-t.C:
			if err := srv.Send(getCurrentTime()); err != nil {
				return err
			}
		case <-srv.Context().Done():
			log.Println("Current Time Stream Done")
			return nil
		}
	}
}

func (s server) Timer(req *pb.TimerRequest, srv pb.ClockService_TimerServer) error {
	log.Println("Timer Stream Started")
	remainingTime := req.Length
	t := time.NewTicker(time.Second * 1)
	defer t.Stop()
	for {
		select {
		case <-t.C:
			remainingTime -= 1
			if remainingTime == 0 {
				if err := srv.Send(&pb.TimerResponse{TimeLeft: remainingTime, Message: req.Message}); err != nil {
					return err
				}
				log.Println("Timer Stream Done")
				return nil
			}
			if err := srv.Send(&pb.TimerResponse{TimeLeft: remainingTime, Message: ""}); err != nil {
				return err
			}
		case <-srv.Context().Done():
			log.Println("Timer Stream Done")
			return nil
		}
	}
}

func getCurrentTime() *pb.Time {
	return &pb.Time{
		Time: timestamppb.Now(),
	}
}
