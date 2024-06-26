// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceEnvironmentResource : IJsonModel<AppServiceEnvironmentData>
    {
        void IJsonModel<AppServiceEnvironmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AppServiceEnvironmentData>)Data).Write(writer, options);

        AppServiceEnvironmentData IJsonModel<AppServiceEnvironmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AppServiceEnvironmentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AppServiceEnvironmentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AppServiceEnvironmentData IPersistableModel<AppServiceEnvironmentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AppServiceEnvironmentData>(data, options);

        string IPersistableModel<AppServiceEnvironmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AppServiceEnvironmentData>)Data).GetFormatFromOptions(options);
    }
}
