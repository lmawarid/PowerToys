﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Text.Json;
using Microsoft.PowerToys.Settings.UI.Libs;
using Microsoft.PowerToys.Settings.UI.Libs.ViewModels;
using Microsoft.PowerToys.Settings.UI.UnitTests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ViewModelTests
{
    [TestClass]
    public class PowerPreview
    {
        public const string Module = "Test\\File Explorer";

        private Mock<ISettingsUtils> mockPowerPreviewSettingsUtils;

        [TestInitialize]
        public void SetUpStubSettingUtils()
        {
            mockPowerPreviewSettingsUtils = ISettingsUtilsMocks.GetStubSettingsUtils<PowerPreviewSettings>();
        }

        [TestMethod]
        public void SVGRenderIsEnabledShouldPrevHandlerWhenSuccessful()
        {
            // Assert
            Func<string, int> SendMockIPCConfigMSG = msg =>
            {
                SndModuleSettings<SndPowerPreviewSettings> snd = JsonSerializer.Deserialize<SndModuleSettings<SndPowerPreviewSettings>>(msg);
                Assert.IsTrue(snd.PowertoysSetting.FileExplorerPreviewSettings.Properties.EnableSvgPreview);
                return 0;
            };

            // arrange
            PowerPreviewViewModel viewModel = new PowerPreviewViewModel(SettingsRepository<PowerPreviewSettings>.GetInstance(mockPowerPreviewSettingsUtils.Object), SendMockIPCConfigMSG, Module);

            // act
            viewModel.SVGRenderIsEnabled = true;
        }

        [TestMethod]
        public void SVGThumbnailIsEnabledShouldPrevHandlerWhenSuccessful()
        {
            // Assert
            Func<string, int> SendMockIPCConfigMSG = msg =>
            {
                SndModuleSettings<SndPowerPreviewSettings> snd = JsonSerializer.Deserialize<SndModuleSettings<SndPowerPreviewSettings>>(msg);
                Assert.IsTrue(snd.PowertoysSetting.FileExplorerPreviewSettings.Properties.EnableSvgThumbnail);
                return 0;
            };

            // arrange
            PowerPreviewViewModel viewModel = new PowerPreviewViewModel(SettingsRepository<PowerPreviewSettings>.GetInstance(mockPowerPreviewSettingsUtils.Object), SendMockIPCConfigMSG, Module);

            // act
            viewModel.SVGThumbnailIsEnabled = true;
        }

        [TestMethod]
        public void MDRenderIsEnabledShouldPrevHandlerWhenSuccessful()
        {
            // Assert
            Func<string, int> SendMockIPCConfigMSG = msg =>
            {
                SndModuleSettings<SndPowerPreviewSettings> snd = JsonSerializer.Deserialize<SndModuleSettings<SndPowerPreviewSettings>>(msg);
                Assert.IsTrue(snd.PowertoysSetting.FileExplorerPreviewSettings.Properties.EnableMdPreview);
                return 0;
            };

            // arrange
            PowerPreviewViewModel viewModel = new PowerPreviewViewModel(SettingsRepository<PowerPreviewSettings>.GetInstance(mockPowerPreviewSettingsUtils.Object), SendMockIPCConfigMSG, Module); ;

            // act
            viewModel.MDRenderIsEnabled = true;
        }
    }
}
