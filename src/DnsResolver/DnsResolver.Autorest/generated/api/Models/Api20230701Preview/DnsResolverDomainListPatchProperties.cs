// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Extensions;

    /// <summary>Represents the updatable properties of a DNS resolver domain list.</summary>
    public partial class DnsResolverDomainListPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverDomainListPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsResolverDomainListPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string[] _domain;

        /// <summary>The domains in the domain list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Origin(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.PropertyOrigin.Owned)]
        public string[] Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Creates an new <see cref="DnsResolverDomainListPatchProperties" /> instance.</summary>
        public DnsResolverDomainListPatchProperties()
        {

        }
    }
    /// Represents the updatable properties of a DNS resolver domain list.
    public partial interface IDnsResolverDomainListPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.IJsonSerializable
    {
        /// <summary>The domains in the domain list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The domains in the domain list.",
        SerializedName = @"domains",
        PossibleTypes = new [] { typeof(string) })]
        string[] Domain { get; set; }

    }
    /// Represents the updatable properties of a DNS resolver domain list.
    internal partial interface IDnsResolverDomainListPatchPropertiesInternal

    {
        /// <summary>The domains in the domain list.</summary>
        string[] Domain { get; set; }

    }
}