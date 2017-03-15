// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: servermgr.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Suresecureivs {
  public static class ServiceNotice
  {
    static readonly string __ServiceName = "suresecureivs.ServiceNotice";

    static readonly Marshaller<global::Suresecureivs.SvrDevice> __Marshaller_SvrDevice = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Suresecureivs.SvrDevice.Parser.ParseFrom);
    static readonly Marshaller<global::Suresecureivs.MsgReply> __Marshaller_MsgReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Suresecureivs.MsgReply.Parser.ParseFrom);
    static readonly Marshaller<global::Suresecureivs.SvrClient> __Marshaller_SvrClient = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Suresecureivs.SvrClient.Parser.ParseFrom);
    static readonly Marshaller<global::Suresecureivs.SvrDeviceAll> __Marshaller_SvrDeviceAll = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Suresecureivs.SvrDeviceAll.Parser.ParseFrom);
    static readonly Marshaller<global::Suresecureivs.SvrClientAll> __Marshaller_SvrClientAll = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Suresecureivs.SvrClientAll.Parser.ParseFrom);
    static readonly Marshaller<global::Suresecureivs.MsgInfo> __Marshaller_MsgInfo = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Suresecureivs.MsgInfo.Parser.ParseFrom);

    static readonly Method<global::Suresecureivs.SvrDevice, global::Suresecureivs.MsgReply> __Method_DeviceStatusChange = new Method<global::Suresecureivs.SvrDevice, global::Suresecureivs.MsgReply>(
        MethodType.Unary,
        __ServiceName,
        "DeviceStatusChange",
        __Marshaller_SvrDevice,
        __Marshaller_MsgReply);

    static readonly Method<global::Suresecureivs.SvrClient, global::Suresecureivs.MsgReply> __Method_ClientStatusChange = new Method<global::Suresecureivs.SvrClient, global::Suresecureivs.MsgReply>(
        MethodType.Unary,
        __ServiceName,
        "ClientStatusChange",
        __Marshaller_SvrClient,
        __Marshaller_MsgReply);

    static readonly Method<global::Suresecureivs.SvrDeviceAll, global::Suresecureivs.MsgReply> __Method_DevicesList = new Method<global::Suresecureivs.SvrDeviceAll, global::Suresecureivs.MsgReply>(
        MethodType.Unary,
        __ServiceName,
        "DevicesList",
        __Marshaller_SvrDeviceAll,
        __Marshaller_MsgReply);

    static readonly Method<global::Suresecureivs.SvrClientAll, global::Suresecureivs.MsgReply> __Method_ClientsList = new Method<global::Suresecureivs.SvrClientAll, global::Suresecureivs.MsgReply>(
        MethodType.Unary,
        __ServiceName,
        "ClientsList",
        __Marshaller_SvrClientAll,
        __Marshaller_MsgReply);

    static readonly Method<global::Suresecureivs.MsgInfo, global::Suresecureivs.MsgReply> __Method_OnMessage = new Method<global::Suresecureivs.MsgInfo, global::Suresecureivs.MsgReply>(
        MethodType.Unary,
        __ServiceName,
        "OnMessage",
        __Marshaller_MsgInfo,
        __Marshaller_MsgReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Suresecureivs.ServermgrReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServiceNotice</summary>
    public abstract class ServiceNoticeBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Suresecureivs.MsgReply> DeviceStatusChange(global::Suresecureivs.SvrDevice request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Suresecureivs.MsgReply> ClientStatusChange(global::Suresecureivs.SvrClient request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Suresecureivs.MsgReply> DevicesList(global::Suresecureivs.SvrDeviceAll request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Suresecureivs.MsgReply> ClientsList(global::Suresecureivs.SvrClientAll request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Suresecureivs.MsgReply> OnMessage(global::Suresecureivs.MsgInfo request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ServiceNotice</summary>
    public class ServiceNoticeClient : ClientBase<ServiceNoticeClient>
    {
      /// <summary>Creates a new client for ServiceNotice</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ServiceNoticeClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ServiceNotice that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ServiceNoticeClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ServiceNoticeClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ServiceNoticeClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Suresecureivs.MsgReply DeviceStatusChange(global::Suresecureivs.SvrDevice request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeviceStatusChange(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Suresecureivs.MsgReply DeviceStatusChange(global::Suresecureivs.SvrDevice request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeviceStatusChange, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> DeviceStatusChangeAsync(global::Suresecureivs.SvrDevice request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeviceStatusChangeAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> DeviceStatusChangeAsync(global::Suresecureivs.SvrDevice request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeviceStatusChange, null, options, request);
      }
      public virtual global::Suresecureivs.MsgReply ClientStatusChange(global::Suresecureivs.SvrClient request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClientStatusChange(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Suresecureivs.MsgReply ClientStatusChange(global::Suresecureivs.SvrClient request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ClientStatusChange, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> ClientStatusChangeAsync(global::Suresecureivs.SvrClient request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClientStatusChangeAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> ClientStatusChangeAsync(global::Suresecureivs.SvrClient request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ClientStatusChange, null, options, request);
      }
      public virtual global::Suresecureivs.MsgReply DevicesList(global::Suresecureivs.SvrDeviceAll request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DevicesList(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Suresecureivs.MsgReply DevicesList(global::Suresecureivs.SvrDeviceAll request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DevicesList, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> DevicesListAsync(global::Suresecureivs.SvrDeviceAll request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DevicesListAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> DevicesListAsync(global::Suresecureivs.SvrDeviceAll request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DevicesList, null, options, request);
      }
      public virtual global::Suresecureivs.MsgReply ClientsList(global::Suresecureivs.SvrClientAll request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClientsList(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Suresecureivs.MsgReply ClientsList(global::Suresecureivs.SvrClientAll request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ClientsList, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> ClientsListAsync(global::Suresecureivs.SvrClientAll request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClientsListAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> ClientsListAsync(global::Suresecureivs.SvrClientAll request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ClientsList, null, options, request);
      }
      public virtual global::Suresecureivs.MsgReply OnMessage(global::Suresecureivs.MsgInfo request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return OnMessage(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Suresecureivs.MsgReply OnMessage(global::Suresecureivs.MsgInfo request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnMessage, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> OnMessageAsync(global::Suresecureivs.MsgInfo request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return OnMessageAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Suresecureivs.MsgReply> OnMessageAsync(global::Suresecureivs.MsgInfo request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnMessage, null, options, request);
      }
      protected override ServiceNoticeClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServiceNoticeClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ServiceNoticeBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeviceStatusChange, serviceImpl.DeviceStatusChange)
          .AddMethod(__Method_ClientStatusChange, serviceImpl.ClientStatusChange)
          .AddMethod(__Method_DevicesList, serviceImpl.DevicesList)
          .AddMethod(__Method_ClientsList, serviceImpl.ClientsList)
          .AddMethod(__Method_OnMessage, serviceImpl.OnMessage).Build();
    }

  }
}
#endregion
