// -----------------------------------------------------------------------
// <copyright file="PluginConfig.cs" company="{{cookiecutter.author}}">
// Copyright (c) {{cookiecutter.author}}. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System.ComponentModel;

using Exiled.API.Interfaces;

namespace {{cookiecutter.plugin_name}}
{
    public class PluginConfig : IConfig
    {
        [Description("Should plugin be enabled or not.")]
        public bool IsEnabled { get; set; } = true;
    }
}