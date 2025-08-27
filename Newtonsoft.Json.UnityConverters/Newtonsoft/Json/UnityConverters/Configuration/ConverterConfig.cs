namespace Newtonsoft.Json.UnityConverters.Configuration;

[DebuggerDisplay("{converterName}, enabled={enabled}")]
public struct ConverterConfig : IEquatable<ConverterConfig>
{
	public bool enabled; //Field offset: 0x0
	public string converterName; //Field offset: 0x8
	public string converterAssembly; //Field offset: 0x10
	public List<KeyedConfig> settings; //Field offset: 0x18

	public virtual bool Equals(object obj) { }

	public override bool Equals(ConverterConfig other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(ConverterConfig left, ConverterConfig right) { }

	public static bool op_Inequality(ConverterConfig left, ConverterConfig right) { }

	public virtual string ToString() { }

}

