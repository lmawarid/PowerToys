// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Libs.CustomAction
{
    public class SendCustomAction
    {
        private readonly string moduleName;

        public SendCustomAction(string moduleName)
        {
            this.moduleName = moduleName;
        }

        [JsonPropertyName("action")]
        public ModuleCustomAction Action { get; set; }

        public string ToJsonString()
        {
            var jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = new CustomNamePolicy((propertyName) =>
                {
                    // Using InvariantCulture comparison as this text is internal.
                    return propertyName.Equals("ModuleAction", System.StringComparison.InvariantCulture) ? moduleName : propertyName;
                }),
            };

            return JsonSerializer.Serialize(this, jsonSerializerOptions);
        }
    }
}
