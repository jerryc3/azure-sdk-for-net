// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The certificate item containing certificate metadata.
    /// </summary>
    public partial class CertificateItem
    {
        /// <summary>
        /// Initializes a new instance of the CertificateItem class.
        /// </summary>
        public CertificateItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateItem class.
        /// </summary>
        /// <param name="id">Certificate identifier.</param>
        /// <param name="attributes">The certificate management
        /// attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        /// <param name="x509Thumbprint">Thumbprint of the certificate.</param>
        public CertificateItem(string id = default(string), CertificateAttributes attributes = default(CertificateAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>), byte[] x509Thumbprint = default(byte[]))
        {
            Id = id;
            Attributes = attributes;
            Tags = tags;
            X509Thumbprint = x509Thumbprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the certificate management attributes.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public CertificateAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets application specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets thumbprint of the certificate.
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "x5t")]
        public byte[] X509Thumbprint { get; set; }

    }
}