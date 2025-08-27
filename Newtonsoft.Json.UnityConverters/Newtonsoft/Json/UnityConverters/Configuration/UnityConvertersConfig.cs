namespace Newtonsoft.Json.UnityConverters.Configuration;

public sealed class UnityConvertersConfig : ScriptableObject
{
	internal const string PATH = "Assets/Resources/Newtonsoft.Json-for-Unity.Converters.asset"; //Field offset: 0x0
	internal const string PATH_FOR_RESOURCES_LOAD = "Newtonsoft.Json-for-Unity.Converters"; //Field offset: 0x0
	public bool useUnityContractResolver; //Field offset: 0x18
	public bool useAllOutsideConverters; //Field offset: 0x19
	public List<ConverterConfig> outsideConverters; //Field offset: 0x20
	public bool useAllUnityConverters; //Field offset: 0x28
	public List<ConverterConfig> unityConverters; //Field offset: 0x30
	public bool useAllJsonNetConverters; //Field offset: 0x38
	public List<ConverterConfig> jsonNetConverters; //Field offset: 0x40
	public bool autoSyncConverters; //Field offset: 0x48

	public UnityConvertersConfig() { }

}

