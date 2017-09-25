﻿using System;

namespace UnityEngine.MaterialGraph
{
    public interface IShaderProperty
    {
        string name { get; set; }
        string description { get; set; }
        PropertyType propertyType { get; }
        Guid guid { get; }
        bool generatePropertyBlock { get; set; }
        Vector4 defaultValue { get; }

        string GetPropertyBlockString();
        string GetPropertyDeclarationString();
        PreviewProperty GetPreviewMaterialProperty();
    }
}
