// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the FunctionEnvelope data model. </summary>
    public partial class FunctionEnvelopeData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of FunctionEnvelopeData. </summary>
        public FunctionEnvelopeData()
        {
            Files = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of FunctionEnvelopeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="functionAppId"> Function App ID. </param>
        /// <param name="scriptRootPathHref"> Script root path URI. </param>
        /// <param name="scriptHref"> Script URI. </param>
        /// <param name="configHref"> Config URI. </param>
        /// <param name="testDataHref"> Test data URI. </param>
        /// <param name="secretsFileHref"> Secrets file URI. </param>
        /// <param name="href"> Function URI. </param>
        /// <param name="config"> Config information. </param>
        /// <param name="files"> File list. </param>
        /// <param name="testData"> Test data used when testing via the Azure Portal. </param>
        /// <param name="invokeUrlTemplate"> The invocation URL. </param>
        /// <param name="language"> The function language. </param>
        /// <param name="isDisabled"> Gets or sets a value indicating whether the function is disabled. </param>
        internal FunctionEnvelopeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string functionAppId, string scriptRootPathHref, string scriptHref, string configHref, string testDataHref, string secretsFileHref, string href, BinaryData config, IDictionary<string, string> files, string testData, string invokeUrlTemplate, string language, bool? isDisabled) : base(id, name, resourceType, systemData, kind)
        {
            FunctionAppId = functionAppId;
            ScriptRootPathHref = scriptRootPathHref;
            ScriptHref = scriptHref;
            ConfigHref = configHref;
            TestDataHref = testDataHref;
            SecretsFileHref = secretsFileHref;
            Href = href;
            Config = config;
            Files = files;
            TestData = testData;
            InvokeUrlTemplate = invokeUrlTemplate;
            Language = language;
            IsDisabled = isDisabled;
        }

        /// <summary> Function App ID. </summary>
        public string FunctionAppId { get; set; }
        /// <summary> Script root path URI. </summary>
        public string ScriptRootPathHref { get; set; }
        /// <summary> Script URI. </summary>
        public string ScriptHref { get; set; }
        /// <summary> Config URI. </summary>
        public string ConfigHref { get; set; }
        /// <summary> Test data URI. </summary>
        public string TestDataHref { get; set; }
        /// <summary> Secrets file URI. </summary>
        public string SecretsFileHref { get; set; }
        /// <summary> Function URI. </summary>
        public string Href { get; set; }
        /// <summary> Config information. </summary>
        public BinaryData Config { get; set; }
        /// <summary> File list. </summary>
        public IDictionary<string, string> Files { get; }
        /// <summary> Test data used when testing via the Azure Portal. </summary>
        public string TestData { get; set; }
        /// <summary> The invocation URL. </summary>
        public string InvokeUrlTemplate { get; set; }
        /// <summary> The function language. </summary>
        public string Language { get; set; }
        /// <summary> Gets or sets a value indicating whether the function is disabled. </summary>
        public bool? IsDisabled { get; set; }
    }
}
