// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.MixedReality.ObjectAnchors.Conversion.Models;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    public partial class AssetConversionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (AssetDimensionsWrapper != null)
            {
                if (AssetDimensionsWrapper != null)
                {
                    writer.WritePropertyName("dimensions"u8);
                    writer.WriteObjectValue(AssetDimensionsWrapper);
                }
                else
                {
                    writer.WriteNull("dimensions");
                }
            }
            if (BoundingBoxCenterWrapper != null)
            {
                if (BoundingBoxCenterWrapper != null)
                {
                    writer.WritePropertyName("boundingBoxCenter"u8);
                    writer.WriteObjectValue(BoundingBoxCenterWrapper);
                }
                else
                {
                    writer.WriteNull("boundingBoxCenter");
                }
            }
            writer.WritePropertyName("gravity"u8);
            writer.WriteObjectValue(GravityWrapper);
            if (!(KeyFrameIndexes is ChangeTrackingList<int> collection && collection.IsUndefined))
            {
                if (KeyFrameIndexes != null)
                {
                    writer.WritePropertyName("keyFrameIndexes"u8);
                    writer.WriteStartArray();
                    foreach (var item in KeyFrameIndexes)
                    {
                        writer.WriteNumberValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("keyFrameIndexes");
                }
            }
            if (!(GroundTruthTrajectoryCameraPoses is ChangeTrackingList<TrajectoryPose> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("gtTrajectory"u8);
                writer.WriteStartArray();
                foreach (var item in GroundTruthTrajectoryCameraPoses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PrincipalAxisWrapper != null)
            {
                if (PrincipalAxisWrapper != null)
                {
                    writer.WritePropertyName("principalAxis"u8);
                    writer.WriteObjectValue(PrincipalAxisWrapper);
                }
                else
                {
                    writer.WriteNull("principalAxis");
                }
            }
            writer.WritePropertyName("scale"u8);
            writer.WriteNumberValue(Scale);
            writer.WritePropertyName("disableDetectScaleUnits"u8);
            writer.WriteBooleanValue(DisableDetectScaleUnits);
            if (SupportingPlaneWrapper != null)
            {
                if (SupportingPlaneWrapper != null)
                {
                    writer.WritePropertyName("supportingPlane"u8);
                    writer.WriteObjectValue(SupportingPlaneWrapper);
                }
                else
                {
                    writer.WriteNull("supportingPlane");
                }
            }
            if (!(TestTrajectoryCameraPoses is ChangeTrackingList<TrajectoryPose> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("testTrajectory"u8);
                writer.WriteStartArray();
                foreach (var item in TestTrajectoryCameraPoses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AssetConversionConfiguration DeserializeAssetConversionConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Vector3> dimensions = default;
            Optional<Vector3> boundingBoxCenter = default;
            Vector3 gravity = default;
            IReadOnlyList<int> keyFrameIndexes = default;
            IReadOnlyList<TrajectoryPose> gtTrajectory = default;
            Optional<Quaternion> principalAxis = default;
            float scale = default;
            Optional<bool> disableDetectScaleUnits = default;
            Optional<Vector4> supportingPlane = default;
            IReadOnlyList<TrajectoryPose> testTrajectory = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dimensions = null;
                        continue;
                    }
                    dimensions = Vector3.DeserializeVector3(property.Value);
                    continue;
                }
                if (property.NameEquals("boundingBoxCenter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        boundingBoxCenter = null;
                        continue;
                    }
                    boundingBoxCenter = Vector3.DeserializeVector3(property.Value);
                    continue;
                }
                if (property.NameEquals("gravity"u8))
                {
                    gravity = Vector3.DeserializeVector3(property.Value);
                    continue;
                }
                if (property.NameEquals("keyFrameIndexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    keyFrameIndexes = array;
                    continue;
                }
                if (property.NameEquals("gtTrajectory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TrajectoryPose> array = new List<TrajectoryPose>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrajectoryPose.DeserializeTrajectoryPose(item));
                    }
                    gtTrajectory = array;
                    continue;
                }
                if (property.NameEquals("principalAxis"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        principalAxis = null;
                        continue;
                    }
                    principalAxis = Quaternion.DeserializeQuaternion(property.Value);
                    continue;
                }
                if (property.NameEquals("scale"u8))
                {
                    scale = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("disableDetectScaleUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableDetectScaleUnits = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportingPlane"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        supportingPlane = null;
                        continue;
                    }
                    supportingPlane = Vector4.DeserializeVector4(property.Value);
                    continue;
                }
                if (property.NameEquals("testTrajectory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TrajectoryPose> array = new List<TrajectoryPose>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrajectoryPose.DeserializeTrajectoryPose(item));
                    }
                    testTrajectory = array;
                    continue;
                }
            }
            return new AssetConversionConfiguration(dimensions.Value, boundingBoxCenter.Value, gravity, keyFrameIndexes ?? new ChangeTrackingList<int>(), gtTrajectory ?? new ChangeTrackingList<TrajectoryPose>(), principalAxis.Value, scale, disableDetectScaleUnits, supportingPlane.Value, testTrajectory ?? new ChangeTrackingList<TrajectoryPose>());
        }
    }
}
