﻿using SharedUI.Interfaces;

namespace MobileUI.Services;
public class PlatformService : IPlatformService
{
    public string GetPlatformName() => DeviceInfo.Current.Platform.ToString();
}
