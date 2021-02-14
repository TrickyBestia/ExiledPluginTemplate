// -----------------------------------------------------------------------
// <copyright file="Plugin.cs" company="{{cookiecutter.author}}">
// Copyright (c) {{cookiecutter.author}}. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using Exiled.API.Features;

namespace {{cookiecutter.plugin_name}}
{
    public class Plugin : Plugin<PluginConfig>
    {
        public override string Author { get; } = "{{cookiecutter.author}}";

        public override string Name { get; } = "{{cookiecutter.plugin_name}}";

        public override string Prefix { get; } = "{{cookiecutter.plugin_name}}";

        public override void OnEnabled()
        {
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}