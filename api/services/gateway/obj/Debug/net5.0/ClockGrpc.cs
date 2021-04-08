// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: clock.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Protoclock {
  public static partial class clockService
  {
    static readonly string __ServiceName = "protoclock.clockService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Protoclock.currentTimeRequest> __Marshaller_protoclock_currentTimeRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protoclock.currentTimeRequest.Parser));
    static readonly grpc::Marshaller<global::Protoclock.time> __Marshaller_protoclock_time = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protoclock.time.Parser));

    static readonly grpc::Method<global::Protoclock.currentTimeRequest, global::Protoclock.time> __Method_currentTime = new grpc::Method<global::Protoclock.currentTimeRequest, global::Protoclock.time>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "currentTime",
        __Marshaller_protoclock_currentTimeRequest,
        __Marshaller_protoclock_time);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Protoclock.ClockReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of clockService</summary>
    [grpc::BindServiceMethod(typeof(clockService), "BindService")]
    public abstract partial class clockServiceBase
    {
      public virtual global::System.Threading.Tasks.Task currentTime(global::Protoclock.currentTimeRequest request, grpc::IServerStreamWriter<global::Protoclock.time> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for clockService</summary>
    public partial class clockServiceClient : grpc::ClientBase<clockServiceClient>
    {
      /// <summary>Creates a new client for clockService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public clockServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for clockService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public clockServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected clockServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected clockServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Protoclock.time> currentTime(global::Protoclock.currentTimeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return currentTime(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Protoclock.time> currentTime(global::Protoclock.currentTimeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_currentTime, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override clockServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new clockServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(clockServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_currentTime, serviceImpl.currentTime).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, clockServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_currentTime, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Protoclock.currentTimeRequest, global::Protoclock.time>(serviceImpl.currentTime));
    }

  }
}
#endregion
