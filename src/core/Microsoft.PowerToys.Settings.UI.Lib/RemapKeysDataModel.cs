// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Lib
{
    public class RemapKeysDataModel
    {
        // Collection properties should be read-only (CA2227)
        [JsonPropertyName("inProcess")]
        public List<KeysDataModel> InProcessRemapKeys { get; }

        public RemapKeysDataModel()
        {
            InProcessRemapKeys = new List<KeysDataModel>();
        }

        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
