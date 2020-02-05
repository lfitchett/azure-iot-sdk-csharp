﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.Client
{
    using Microsoft.Azure.Devices.Shared;
    using System;
    using System.Net;
    using System.Security.Cryptography.X509Certificates;

    /// <summary>
    /// contains Http1 transport-specific settings for DeviceClient
    /// </summary>
    public sealed class Http1TransportSettings : ITransportSettings
    {
        static readonly TimeSpan DefaultOperationTimeout = TimeSpan.FromSeconds(60);

        public Http1TransportSettings()
        {
            this.Proxy = DefaultWebProxySettings.Instance;
        }

        public TransportType GetTransportType()
        {
            return TransportType.Http1;
        }

        public X509Certificate2 ClientCertificate { get; set; }

        public TimeSpan GetDefaultReceiveTimeout()
        {
            return DefaultOperationTimeout;
        }

        public IWebProxy Proxy { get; set; }
    }
}
