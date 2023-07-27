// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToSourceSqlServerTaskOutput
    {
        internal static ConnectToSourceSqlServerTaskOutput DeserializeConnectToSourceSqlServerTaskOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AgentJobLevelOutput": return ConnectToSourceSqlServerTaskOutputAgentJobLevel.DeserializeConnectToSourceSqlServerTaskOutputAgentJobLevel(element);
                    case "DatabaseLevelOutput": return ConnectToSourceSqlServerTaskOutputDatabaseLevel.DeserializeConnectToSourceSqlServerTaskOutputDatabaseLevel(element);
                    case "LoginLevelOutput": return ConnectToSourceSqlServerTaskOutputLoginLevel.DeserializeConnectToSourceSqlServerTaskOutputLoginLevel(element);
                    case "TaskLevelOutput": return ConnectToSourceSqlServerTaskOutputTaskLevel.DeserializeConnectToSourceSqlServerTaskOutputTaskLevel(element);
                }
            }
            return UnknownConnectToSourceSqlServerTaskOutput.DeserializeUnknownConnectToSourceSqlServerTaskOutput(element);
        }
    }
}
