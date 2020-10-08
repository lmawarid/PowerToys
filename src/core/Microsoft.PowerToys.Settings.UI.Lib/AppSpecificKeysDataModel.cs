﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Lib
{
    public class AppSpecificKeysDataModel : KeysDataModel
    {
        [JsonPropertyName("targetApp")]
        public string TargetApp { get; set; }

        // Renamed from GetOriginalKeys -> GetMappedOriginalKeys to avoid confusion with
        // property names (FxCop rule CA1721).
        public new List<string> GetMappedOriginalKeys()
        {
            return base.GetMappedOriginalKeys();
        }

        // Renamed from GetNewRemapKeys -> GetMappedNewRemapKeys to avoid confusion with
        // property names (FxCop rule CA1721).
        public new List<string> GetMappedNewRemapKeys()
        {
            return base.GetMappedNewRemapKeys();
        }

        public bool Compare(AppSpecificKeysDataModel arg)
        {
            return OriginalKeys.Equals(arg.OriginalKeys) && NewRemapKeys.Equals(arg.NewRemapKeys) && TargetApp.Equals(arg.TargetApp);
        }
    }
}
