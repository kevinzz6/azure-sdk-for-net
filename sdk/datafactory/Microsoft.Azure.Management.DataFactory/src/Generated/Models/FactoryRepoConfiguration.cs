// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Factory's git repo information.
    /// </summary>
    public partial class FactoryRepoConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the FactoryRepoConfiguration class.
        /// </summary>
        public FactoryRepoConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FactoryRepoConfiguration class.
        /// </summary>
        /// <param name="accountName">Account name.</param>
        /// <param name="repositoryName">Repository name.</param>
        /// <param name="collaborationBranch">Collaboration branch.</param>
        /// <param name="rootFolder">Root folder.</param>
        /// <param name="lastCommitId">Last commit id.</param>
        /// <param name="disablePublish">Disable manual publish operation in
        /// ADF studio to favor automated publish.</param>
        public FactoryRepoConfiguration(string accountName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId = default(string), bool? disablePublish = default(bool?))
        {
            AccountName = accountName;
            RepositoryName = repositoryName;
            CollaborationBranch = collaborationBranch;
            RootFolder = rootFolder;
            LastCommitId = lastCommitId;
            DisablePublish = disablePublish;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets account name.
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets repository name.
        /// </summary>
        [JsonProperty(PropertyName = "repositoryName")]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Gets or sets collaboration branch.
        /// </summary>
        [JsonProperty(PropertyName = "collaborationBranch")]
        public string CollaborationBranch { get; set; }

        /// <summary>
        /// Gets or sets root folder.
        /// </summary>
        [JsonProperty(PropertyName = "rootFolder")]
        public string RootFolder { get; set; }

        /// <summary>
        /// Gets or sets last commit id.
        /// </summary>
        [JsonProperty(PropertyName = "lastCommitId")]
        public string LastCommitId { get; set; }

        /// <summary>
        /// Gets or sets disable manual publish operation in ADF studio to
        /// favor automated publish.
        /// </summary>
        [JsonProperty(PropertyName = "disablePublish")]
        public bool? DisablePublish { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountName");
            }
            if (RepositoryName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RepositoryName");
            }
            if (CollaborationBranch == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CollaborationBranch");
            }
            if (RootFolder == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RootFolder");
            }
        }
    }
}
