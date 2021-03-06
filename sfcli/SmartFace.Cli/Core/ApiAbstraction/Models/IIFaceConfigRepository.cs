﻿using SmartFace.Cli.Core.ApiAbstraction.Models.Configs;

namespace SmartFace.Cli.Core.ApiAbstraction.Models
{
    public interface IIFaceConfigRepository
    {
        IFaceConfigModel Get(IFaceConfigKey key);

        void Set(IFaceConfigKey key, IFaceConfigModel configModel);
    }

    public enum IFaceConfigKey
    {
        Camera,
        Detect,
        Extract,
        Grouping
    }
}
