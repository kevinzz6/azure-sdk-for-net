// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for the task that collects user tables for the given list of databases. </summary>
    public partial class GetUserTablesSqlTaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of GetUserTablesSqlTaskProperties. </summary>
        public GetUserTablesSqlTaskProperties()
        {
            Output = new ChangeTrackingList<GetUserTablesSqlTaskOutput>();
            TaskType = TaskType.GetUserTablesSql;
        }

        /// <summary> Initializes a new instance of GetUserTablesSqlTaskProperties. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/>, <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="input"> Task input. </param>
        /// <param name="output"> Task output. This is ignored if submitted. </param>
        /// <param name="taskId"> Task id. </param>
        internal GetUserTablesSqlTaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, GetUserTablesSqlTaskInput input, IReadOnlyList<GetUserTablesSqlTaskOutput> output, string taskId) : base(taskType, errors, state, commands, clientData)
        {
            Input = input;
            Output = output;
            TaskId = taskId;
            TaskType = taskType;
        }

        /// <summary> Task input. </summary>
        public GetUserTablesSqlTaskInput Input { get; set; }
        /// <summary> Task output. This is ignored if submitted. </summary>
        public IReadOnlyList<GetUserTablesSqlTaskOutput> Output { get; }
        /// <summary> Task id. </summary>
        public string TaskId { get; set; }
    }
}
