// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ZhaoxiLesson.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Zhaoxi.gRPCDemo.LessonServer {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class ZhaoxiLesson
  {
    static readonly string __ServiceName = "ZhaoxiLesson.ZhaoxiLesson";

    static readonly grpc::Marshaller<global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonRequest> __Marshaller_ZhaoxiLesson_ZhaoxiLessonRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReply> __Marshaller_ZhaoxiLesson_ZhaoxiLessonReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonRequest, global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReply> __Method_FindLesson = new grpc::Method<global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonRequest, global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FindLesson",
        __Marshaller_ZhaoxiLesson_ZhaoxiLessonRequest,
        __Marshaller_ZhaoxiLesson_ZhaoxiLessonReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ZhaoxiLesson</summary>
    public partial class ZhaoxiLessonClient : grpc::ClientBase<ZhaoxiLessonClient>
    {
      /// <summary>Creates a new client for ZhaoxiLesson</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ZhaoxiLessonClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ZhaoxiLesson that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ZhaoxiLessonClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ZhaoxiLessonClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ZhaoxiLessonClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReply FindLesson(global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindLesson(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReply FindLesson(global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FindLesson, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReply> FindLessonAsync(global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindLessonAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonReply> FindLessonAsync(global::Zhaoxi.gRPCDemo.LessonServer.ZhaoxiLessonRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FindLesson, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ZhaoxiLessonClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ZhaoxiLessonClient(configuration);
      }
    }

  }
}
#endregion
