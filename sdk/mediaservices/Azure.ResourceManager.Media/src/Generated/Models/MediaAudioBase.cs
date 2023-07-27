// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Defines the common properties for all audio codecs.
    /// Please note <see cref="MediaAudioBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AacAudio"/> and <see cref="DDAudio"/>.
    /// </summary>
    public partial class MediaAudioBase : MediaCodecBase
    {
        /// <summary> Initializes a new instance of MediaAudioBase. </summary>
        public MediaAudioBase()
        {
            OdataType = "#Microsoft.Media.Audio";
        }

        /// <summary> Initializes a new instance of MediaAudioBase. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        /// <param name="channels"> The number of channels in the audio. </param>
        /// <param name="samplingRate"> The sampling rate to use for encoding in hertz. </param>
        /// <param name="bitrate"> The bitrate, in bits per second, of the output encoded audio. </param>
        internal MediaAudioBase(string odataType, string label, int? channels, int? samplingRate, int? bitrate) : base(odataType, label)
        {
            Channels = channels;
            SamplingRate = samplingRate;
            Bitrate = bitrate;
            OdataType = odataType ?? "#Microsoft.Media.Audio";
        }

        /// <summary> The number of channels in the audio. </summary>
        public int? Channels { get; set; }
        /// <summary> The sampling rate to use for encoding in hertz. </summary>
        public int? SamplingRate { get; set; }
        /// <summary> The bitrate, in bits per second, of the output encoded audio. </summary>
        public int? Bitrate { get; set; }
    }
}
