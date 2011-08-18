﻿using Cassette.ModuleProcessing;

namespace Cassette.Scripts
{
    public class CompileCoffeeScript : ModuleProcessorOfAssetsMatchingFileExtension<Module>
    {
        public CompileCoffeeScript(ICompiler coffeeScriptCompiler)
            : base("coffee")
        {
            this.coffeeScriptCompiler = coffeeScriptCompiler;
        }

        readonly ICompiler coffeeScriptCompiler;

        protected override void Process(IAsset asset, Module module)
        {
            asset.AddAssetTransformer(new CompileAsset(coffeeScriptCompiler));
            module.RegisterCompiledAsset(asset, "coffee");
        }
    }
}