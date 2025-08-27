namespace UnityEngine.Rendering.Universal;

public static class ShaderInput
{
	[GenerateHLSL(PackingRules::Exact (0), False, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@056626336c36\\ShaderLibrary\\ShaderTypes.cs")]
	internal struct LightData
	{
		public Vector4 position; //Field offset: 0x0
		public Vector4 color; //Field offset: 0x10
		public Vector4 attenuation; //Field offset: 0x20
		public Vector4 spotDirection; //Field offset: 0x30
		public Vector4 occlusionProbeChannels; //Field offset: 0x40
		public uint layerMask; //Field offset: 0x50

	}


}

