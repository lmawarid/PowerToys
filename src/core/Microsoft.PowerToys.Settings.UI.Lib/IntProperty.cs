﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Libs
{
    // Represents the configuration property of the settings that store Integer type.
    public class IntProperty
    {
        public IntProperty()
        {
            Value = 0;
        }

        public IntProperty(int value)
        {
            Value = value;
        }

        // Gets or sets the integer value of the settings configuration.
        [JsonPropertyName("value")]
        public int Value { get; set; }

        // Returns a JSON version of the class settings configuration class.
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
