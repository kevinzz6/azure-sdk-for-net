// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceNotebookAccessTokenResult. </summary>
    public partial class MachineLearningWorkspaceNotebookAccessTokenResult
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspaceNotebookAccessTokenResult. </summary>
        internal MachineLearningWorkspaceNotebookAccessTokenResult()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningWorkspaceNotebookAccessTokenResult. </summary>
        /// <param name="notebookResourceId"></param>
        /// <param name="hostName"></param>
        /// <param name="publicDns"></param>
        /// <param name="accessToken"></param>
        /// <param name="tokenType"></param>
        /// <param name="expiresIn"></param>
        /// <param name="refreshToken"></param>
        /// <param name="scope"></param>
        internal MachineLearningWorkspaceNotebookAccessTokenResult(string notebookResourceId, string hostName, string publicDns, string accessToken, string tokenType, int? expiresIn, string refreshToken, string scope)
        {
            NotebookResourceId = notebookResourceId;
            HostName = hostName;
            PublicDns = publicDns;
            AccessToken = accessToken;
            TokenType = tokenType;
            ExpiresIn = expiresIn;
            RefreshToken = refreshToken;
            Scope = scope;
        }

        /// <summary> Gets the notebook resource id. </summary>
        public string NotebookResourceId { get; }
        /// <summary> Gets the host name. </summary>
        public string HostName { get; }
        /// <summary> Gets the public dns. </summary>
        public string PublicDns { get; }
        /// <summary> Gets the access token. </summary>
        public string AccessToken { get; }
        /// <summary> Gets the token type. </summary>
        public string TokenType { get; }
        /// <summary> Gets the expires in. </summary>
        public int? ExpiresIn { get; }
        /// <summary> Gets the refresh token. </summary>
        public string RefreshToken { get; }
        /// <summary> Gets the scope. </summary>
        public string Scope { get; }
    }
}
