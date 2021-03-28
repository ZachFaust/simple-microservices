// Code generated by protoc-gen-go-grpc. DO NOT EDIT.

package protoclock

import (
	context "context"
	grpc "google.golang.org/grpc"
	codes "google.golang.org/grpc/codes"
	status "google.golang.org/grpc/status"
)

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
// Requires gRPC-Go v1.32.0 or later.
const _ = grpc.SupportPackageIsVersion7

// ClockServiceClient is the client API for ClockService service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://pkg.go.dev/google.golang.org/grpc/?tab=doc#ClientConn.NewStream.
type ClockServiceClient interface {
	CurrentTime(ctx context.Context, in *CurrentTimeRequest, opts ...grpc.CallOption) (ClockService_CurrentTimeClient, error)
}

type clockServiceClient struct {
	cc grpc.ClientConnInterface
}

func NewClockServiceClient(cc grpc.ClientConnInterface) ClockServiceClient {
	return &clockServiceClient{cc}
}

func (c *clockServiceClient) CurrentTime(ctx context.Context, in *CurrentTimeRequest, opts ...grpc.CallOption) (ClockService_CurrentTimeClient, error) {
	stream, err := c.cc.NewStream(ctx, &ClockService_ServiceDesc.Streams[0], "/protoclock.clockService/currentTime", opts...)
	if err != nil {
		return nil, err
	}
	x := &clockServiceCurrentTimeClient{stream}
	if err := x.ClientStream.SendMsg(in); err != nil {
		return nil, err
	}
	if err := x.ClientStream.CloseSend(); err != nil {
		return nil, err
	}
	return x, nil
}

type ClockService_CurrentTimeClient interface {
	Recv() (*Time, error)
	grpc.ClientStream
}

type clockServiceCurrentTimeClient struct {
	grpc.ClientStream
}

func (x *clockServiceCurrentTimeClient) Recv() (*Time, error) {
	m := new(Time)
	if err := x.ClientStream.RecvMsg(m); err != nil {
		return nil, err
	}
	return m, nil
}

// ClockServiceServer is the server API for ClockService service.
// All implementations must embed UnimplementedClockServiceServer
// for forward compatibility
type ClockServiceServer interface {
	CurrentTime(*CurrentTimeRequest, ClockService_CurrentTimeServer) error
	mustEmbedUnimplementedClockServiceServer()
}

// UnimplementedClockServiceServer must be embedded to have forward compatible implementations.
type UnimplementedClockServiceServer struct {
}

func (UnimplementedClockServiceServer) CurrentTime(*CurrentTimeRequest, ClockService_CurrentTimeServer) error {
	return status.Errorf(codes.Unimplemented, "method CurrentTime not implemented")
}
func (UnimplementedClockServiceServer) mustEmbedUnimplementedClockServiceServer() {}

// UnsafeClockServiceServer may be embedded to opt out of forward compatibility for this service.
// Use of this interface is not recommended, as added methods to ClockServiceServer will
// result in compilation errors.
type UnsafeClockServiceServer interface {
	mustEmbedUnimplementedClockServiceServer()
}

func RegisterClockServiceServer(s grpc.ServiceRegistrar, srv ClockServiceServer) {
	s.RegisterService(&ClockService_ServiceDesc, srv)
}

func _ClockService_CurrentTime_Handler(srv interface{}, stream grpc.ServerStream) error {
	m := new(CurrentTimeRequest)
	if err := stream.RecvMsg(m); err != nil {
		return err
	}
	return srv.(ClockServiceServer).CurrentTime(m, &clockServiceCurrentTimeServer{stream})
}

type ClockService_CurrentTimeServer interface {
	Send(*Time) error
	grpc.ServerStream
}

type clockServiceCurrentTimeServer struct {
	grpc.ServerStream
}

func (x *clockServiceCurrentTimeServer) Send(m *Time) error {
	return x.ServerStream.SendMsg(m)
}

// ClockService_ServiceDesc is the grpc.ServiceDesc for ClockService service.
// It's only intended for direct use with grpc.RegisterService,
// and not to be introspected or modified (even as a copy)
var ClockService_ServiceDesc = grpc.ServiceDesc{
	ServiceName: "protoclock.clockService",
	HandlerType: (*ClockServiceServer)(nil),
	Methods:     []grpc.MethodDesc{},
	Streams: []grpc.StreamDesc{
		{
			StreamName:    "currentTime",
			Handler:       _ClockService_CurrentTime_Handler,
			ServerStreams: true,
		},
	},
	Metadata: "clock.proto",
}
