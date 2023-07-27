// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Identity Provider details. </summary>
    public partial class ApiManagementIdentityProviderCreateOrUpdateContent : ResourceData
    {
        /// <summary> Initializes a new instance of ApiManagementIdentityProviderCreateOrUpdateContent. </summary>
        public ApiManagementIdentityProviderCreateOrUpdateContent()
        {
            AllowedTenants = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ApiManagementIdentityProviderCreateOrUpdateContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identityProviderType"> Identity Provider Type identifier. </param>
        /// <param name="signInTenant"> The TenantId to use instead of Common when logging into Active Directory. </param>
        /// <param name="allowedTenants"> List of Allowed Tenants when configuring Azure Active Directory login. </param>
        /// <param name="authority"> OpenID Connect discovery endpoint hostname for AAD or AAD B2C. </param>
        /// <param name="signUpPolicyName"> Signup Policy Name. Only applies to AAD B2C Identity Provider. </param>
        /// <param name="signInPolicyName"> Signin Policy Name. Only applies to AAD B2C Identity Provider. </param>
        /// <param name="profileEditingPolicyName"> Profile Editing Policy Name. Only applies to AAD B2C Identity Provider. </param>
        /// <param name="passwordResetPolicyName"> Password Reset Policy Name. Only applies to AAD B2C Identity Provider. </param>
        /// <param name="clientId"> Client Id of the Application in the external Identity Provider. It is App ID for Facebook login, Client ID for Google login, App ID for Microsoft. </param>
        /// <param name="clientSecret"> Client secret of the Application in external Identity Provider, used to authenticate login request. For example, it is App Secret for Facebook login, API Key for Google login, Public Key for Microsoft. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </param>
        internal ApiManagementIdentityProviderCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IdentityProviderType? identityProviderType, string signInTenant, IList<string> allowedTenants, string authority, string signUpPolicyName, string signInPolicyName, string profileEditingPolicyName, string passwordResetPolicyName, string clientId, string clientSecret) : base(id, name, resourceType, systemData)
        {
            IdentityProviderType = identityProviderType;
            SignInTenant = signInTenant;
            AllowedTenants = allowedTenants;
            Authority = authority;
            SignUpPolicyName = signUpPolicyName;
            SignInPolicyName = signInPolicyName;
            ProfileEditingPolicyName = profileEditingPolicyName;
            PasswordResetPolicyName = passwordResetPolicyName;
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        /// <summary> Identity Provider Type identifier. </summary>
        public IdentityProviderType? IdentityProviderType { get; set; }
        /// <summary> The TenantId to use instead of Common when logging into Active Directory. </summary>
        public string SignInTenant { get; set; }
        /// <summary> List of Allowed Tenants when configuring Azure Active Directory login. </summary>
        public IList<string> AllowedTenants { get; }
        /// <summary> OpenID Connect discovery endpoint hostname for AAD or AAD B2C. </summary>
        public string Authority { get; set; }
        /// <summary> Signup Policy Name. Only applies to AAD B2C Identity Provider. </summary>
        public string SignUpPolicyName { get; set; }
        /// <summary> Signin Policy Name. Only applies to AAD B2C Identity Provider. </summary>
        public string SignInPolicyName { get; set; }
        /// <summary> Profile Editing Policy Name. Only applies to AAD B2C Identity Provider. </summary>
        public string ProfileEditingPolicyName { get; set; }
        /// <summary> Password Reset Policy Name. Only applies to AAD B2C Identity Provider. </summary>
        public string PasswordResetPolicyName { get; set; }
        /// <summary> Client Id of the Application in the external Identity Provider. It is App ID for Facebook login, Client ID for Google login, App ID for Microsoft. </summary>
        public string ClientId { get; set; }
        /// <summary> Client secret of the Application in external Identity Provider, used to authenticate login request. For example, it is App Secret for Facebook login, API Key for Google login, Public Key for Microsoft. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value. </summary>
        public string ClientSecret { get; set; }
    }
}
