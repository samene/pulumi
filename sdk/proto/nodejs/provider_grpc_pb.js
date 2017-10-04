// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2016-2017, Pulumi Corporation.  All rights reserved.
//
'use strict';
var grpc = require('grpc');
var provider_pb = require('./provider_pb.js');
var google_protobuf_empty_pb = require('google-protobuf/google/protobuf/empty_pb.js');
var google_protobuf_struct_pb = require('google-protobuf/google/protobuf/struct_pb.js');

function serialize_google_protobuf_Empty(arg) {
  if (!(arg instanceof google_protobuf_empty_pb.Empty)) {
    throw new Error('Expected argument of type google.protobuf.Empty');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_google_protobuf_Empty(buffer_arg) {
  return google_protobuf_empty_pb.Empty.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_CheckRequest(arg) {
  if (!(arg instanceof provider_pb.CheckRequest)) {
    throw new Error('Expected argument of type pulumirpc.CheckRequest');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_CheckRequest(buffer_arg) {
  return provider_pb.CheckRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_CheckResponse(arg) {
  if (!(arg instanceof provider_pb.CheckResponse)) {
    throw new Error('Expected argument of type pulumirpc.CheckResponse');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_CheckResponse(buffer_arg) {
  return provider_pb.CheckResponse.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_ConfigureRequest(arg) {
  if (!(arg instanceof provider_pb.ConfigureRequest)) {
    throw new Error('Expected argument of type pulumirpc.ConfigureRequest');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_ConfigureRequest(buffer_arg) {
  return provider_pb.ConfigureRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_CreateRequest(arg) {
  if (!(arg instanceof provider_pb.CreateRequest)) {
    throw new Error('Expected argument of type pulumirpc.CreateRequest');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_CreateRequest(buffer_arg) {
  return provider_pb.CreateRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_CreateResponse(arg) {
  if (!(arg instanceof provider_pb.CreateResponse)) {
    throw new Error('Expected argument of type pulumirpc.CreateResponse');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_CreateResponse(buffer_arg) {
  return provider_pb.CreateResponse.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_DeleteRequest(arg) {
  if (!(arg instanceof provider_pb.DeleteRequest)) {
    throw new Error('Expected argument of type pulumirpc.DeleteRequest');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_DeleteRequest(buffer_arg) {
  return provider_pb.DeleteRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_DiffRequest(arg) {
  if (!(arg instanceof provider_pb.DiffRequest)) {
    throw new Error('Expected argument of type pulumirpc.DiffRequest');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_DiffRequest(buffer_arg) {
  return provider_pb.DiffRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_DiffResponse(arg) {
  if (!(arg instanceof provider_pb.DiffResponse)) {
    throw new Error('Expected argument of type pulumirpc.DiffResponse');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_DiffResponse(buffer_arg) {
  return provider_pb.DiffResponse.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_InvokeRequest(arg) {
  if (!(arg instanceof provider_pb.InvokeRequest)) {
    throw new Error('Expected argument of type pulumirpc.InvokeRequest');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_InvokeRequest(buffer_arg) {
  return provider_pb.InvokeRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_InvokeResponse(arg) {
  if (!(arg instanceof provider_pb.InvokeResponse)) {
    throw new Error('Expected argument of type pulumirpc.InvokeResponse');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_InvokeResponse(buffer_arg) {
  return provider_pb.InvokeResponse.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_UpdateRequest(arg) {
  if (!(arg instanceof provider_pb.UpdateRequest)) {
    throw new Error('Expected argument of type pulumirpc.UpdateRequest');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_UpdateRequest(buffer_arg) {
  return provider_pb.UpdateRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_pulumirpc_UpdateResponse(arg) {
  if (!(arg instanceof provider_pb.UpdateResponse)) {
    throw new Error('Expected argument of type pulumirpc.UpdateResponse');
  }
  return new Buffer(arg.serializeBinary());
}

function deserialize_pulumirpc_UpdateResponse(buffer_arg) {
  return provider_pb.UpdateResponse.deserializeBinary(new Uint8Array(buffer_arg));
}


// ResourceProvider is a service that understands how to create, read, update, or delete resources for types defined
// within a single package.  It is driven by the overall planning engine in response to resource diffs.
var ResourceProviderService = exports.ResourceProviderService = {
  // Configure configures the resource provider with "globals" that control its behavior.
  configure: {
    path: '/pulumirpc.ResourceProvider/Configure',
    requestStream: false,
    responseStream: false,
    requestType: provider_pb.ConfigureRequest,
    responseType: google_protobuf_empty_pb.Empty,
    requestSerialize: serialize_pulumirpc_ConfigureRequest,
    requestDeserialize: deserialize_pulumirpc_ConfigureRequest,
    responseSerialize: serialize_google_protobuf_Empty,
    responseDeserialize: deserialize_google_protobuf_Empty,
  },
  // Invoke dynamically executes a built-in function in the provider.
  invoke: {
    path: '/pulumirpc.ResourceProvider/Invoke',
    requestStream: false,
    responseStream: false,
    requestType: provider_pb.InvokeRequest,
    responseType: provider_pb.InvokeResponse,
    requestSerialize: serialize_pulumirpc_InvokeRequest,
    requestDeserialize: deserialize_pulumirpc_InvokeRequest,
    responseSerialize: serialize_pulumirpc_InvokeResponse,
    responseDeserialize: deserialize_pulumirpc_InvokeResponse,
  },
  // Check validates that the given property bag is valid for a resource of the given type.
  check: {
    path: '/pulumirpc.ResourceProvider/Check',
    requestStream: false,
    responseStream: false,
    requestType: provider_pb.CheckRequest,
    responseType: provider_pb.CheckResponse,
    requestSerialize: serialize_pulumirpc_CheckRequest,
    requestDeserialize: deserialize_pulumirpc_CheckRequest,
    responseSerialize: serialize_pulumirpc_CheckResponse,
    responseDeserialize: deserialize_pulumirpc_CheckResponse,
  },
  // Diff checks what impacts a hypothetical update will have on the resource's properties.
  diff: {
    path: '/pulumirpc.ResourceProvider/Diff',
    requestStream: false,
    responseStream: false,
    requestType: provider_pb.DiffRequest,
    responseType: provider_pb.DiffResponse,
    requestSerialize: serialize_pulumirpc_DiffRequest,
    requestDeserialize: deserialize_pulumirpc_DiffRequest,
    responseSerialize: serialize_pulumirpc_DiffResponse,
    responseDeserialize: deserialize_pulumirpc_DiffResponse,
  },
  // Create allocates a new instance of the provided resource and returns its unique ID afterwards.  (The input ID
  // must be blank.)  If this call fails, the resource must not have been created (i.e., it is "transacational").
  create: {
    path: '/pulumirpc.ResourceProvider/Create',
    requestStream: false,
    responseStream: false,
    requestType: provider_pb.CreateRequest,
    responseType: provider_pb.CreateResponse,
    requestSerialize: serialize_pulumirpc_CreateRequest,
    requestDeserialize: deserialize_pulumirpc_CreateRequest,
    responseSerialize: serialize_pulumirpc_CreateResponse,
    responseDeserialize: deserialize_pulumirpc_CreateResponse,
  },
  // Update updates an existing resource with new values.
  update: {
    path: '/pulumirpc.ResourceProvider/Update',
    requestStream: false,
    responseStream: false,
    requestType: provider_pb.UpdateRequest,
    responseType: provider_pb.UpdateResponse,
    requestSerialize: serialize_pulumirpc_UpdateRequest,
    requestDeserialize: deserialize_pulumirpc_UpdateRequest,
    responseSerialize: serialize_pulumirpc_UpdateResponse,
    responseDeserialize: deserialize_pulumirpc_UpdateResponse,
  },
  // Delete tears down an existing resource with the given ID.  If it fails, the resource is assumed to still exist.
  delete: {
    path: '/pulumirpc.ResourceProvider/Delete',
    requestStream: false,
    responseStream: false,
    requestType: provider_pb.DeleteRequest,
    responseType: google_protobuf_empty_pb.Empty,
    requestSerialize: serialize_pulumirpc_DeleteRequest,
    requestDeserialize: deserialize_pulumirpc_DeleteRequest,
    responseSerialize: serialize_google_protobuf_Empty,
    responseDeserialize: deserialize_google_protobuf_Empty,
  },
};

exports.ResourceProviderClient = grpc.makeGenericClientConstructor(ResourceProviderService);
