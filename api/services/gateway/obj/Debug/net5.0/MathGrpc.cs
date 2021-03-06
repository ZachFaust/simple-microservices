// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: math.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Protomath {
  public static partial class mathService
  {
    static readonly string __ServiceName = "protomath.mathService";

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

    static readonly grpc::Marshaller<global::Protomath.addRequest> __Marshaller_protomath_addRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protomath.addRequest.Parser));
    static readonly grpc::Marshaller<global::Protomath.addResponse> __Marshaller_protomath_addResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protomath.addResponse.Parser));
    static readonly grpc::Marshaller<global::Protomath.divideRequest> __Marshaller_protomath_divideRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protomath.divideRequest.Parser));
    static readonly grpc::Marshaller<global::Protomath.divideResponse> __Marshaller_protomath_divideResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Protomath.divideResponse.Parser));

    static readonly grpc::Method<global::Protomath.addRequest, global::Protomath.addResponse> __Method_add = new grpc::Method<global::Protomath.addRequest, global::Protomath.addResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "add",
        __Marshaller_protomath_addRequest,
        __Marshaller_protomath_addResponse);

    static readonly grpc::Method<global::Protomath.divideRequest, global::Protomath.divideResponse> __Method_divide = new grpc::Method<global::Protomath.divideRequest, global::Protomath.divideResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "divide",
        __Marshaller_protomath_divideRequest,
        __Marshaller_protomath_divideResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Protomath.MathReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of mathService</summary>
    [grpc::BindServiceMethod(typeof(mathService), "BindService")]
    public abstract partial class mathServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Protomath.addResponse> add(global::Protomath.addRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Protomath.divideResponse> divide(global::Protomath.divideRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for mathService</summary>
    public partial class mathServiceClient : grpc::ClientBase<mathServiceClient>
    {
      /// <summary>Creates a new client for mathService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public mathServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for mathService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public mathServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected mathServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected mathServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Protomath.addResponse add(global::Protomath.addRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return add(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protomath.addResponse add(global::Protomath.addRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_add, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protomath.addResponse> addAsync(global::Protomath.addRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return addAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protomath.addResponse> addAsync(global::Protomath.addRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_add, null, options, request);
      }
      public virtual global::Protomath.divideResponse divide(global::Protomath.divideRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return divide(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protomath.divideResponse divide(global::Protomath.divideRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_divide, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protomath.divideResponse> divideAsync(global::Protomath.divideRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return divideAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protomath.divideResponse> divideAsync(global::Protomath.divideRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_divide, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override mathServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new mathServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(mathServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_add, serviceImpl.add)
          .AddMethod(__Method_divide, serviceImpl.divide).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, mathServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_add, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Protomath.addRequest, global::Protomath.addResponse>(serviceImpl.add));
      serviceBinder.AddMethod(__Method_divide, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Protomath.divideRequest, global::Protomath.divideResponse>(serviceImpl.divide));
    }

  }
}
#endregion
