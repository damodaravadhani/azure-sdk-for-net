// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Calling.Server
{
    /// <summary> The request payload for playing audio. </summary>
    public partial class PlayAudioRequest
    {
        /// <summary> Initializes a new instance of PlayAudioRequest. </summary>
        public PlayAudioRequest()
        {
        }

        /// <summary>
        /// The media resource uri of the play audio request.
        /// 
        /// Currently only Wave file (.wav) format audio prompts are supported.
        /// 
        /// More specifically, the audio content in the wave file must be mono (single-channel),
        /// 
        /// 16-bit samples with a 16,000 (16KHz) sampling rate.
        /// </summary>
        public string AudioFileUri { get; set; }
        /// <summary> The flag indicating whether audio file needs to be played in loop or not. </summary>
        public bool? Loop { get; set; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
        /// <summary> An id for the media in the AudioFileUri, using which we cache the media resource. </summary>
        public string AudioFileId { get; set; }
    }
}
