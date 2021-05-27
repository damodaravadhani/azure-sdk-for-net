// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Calling.Server
{
    public partial class StartCallRecordingRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecordingStateCallbackUri))
            {
                writer.WritePropertyName("recordingStateCallbackUri");
                writer.WriteStringValue(RecordingStateCallbackUri);
            }
            writer.WriteEndObject();
        }
    }
}
