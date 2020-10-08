﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.PowerToys.Settings.UI.Libs.Interfaces
{
    public interface ISettingsRepository<T>
    {
        T SettingsConfig { get; set; }
    }
}
