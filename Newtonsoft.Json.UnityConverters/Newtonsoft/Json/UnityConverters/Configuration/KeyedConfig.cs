namespace Newtonsoft.Json.UnityConverters.Configuration;

public struct KeyedConfig : IEquatable<KeyedConfig>
{
	public string key; //Field offset: 0x0
	public ConfigType type; //Field offset: 0x8
	public bool boolean; //Field offset: 0xC
	public int integer; //Field offset: 0x10
	public float number; //Field offset: 0x14
	public string text; //Field offset: 0x18

	public virtual bool Equals(object obj) { }

	public override bool Equals(KeyedConfig other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(KeyedConfig left, KeyedConfig right) { }

	public static bool op_Inequality(KeyedConfig left, KeyedConfig right) { }

}

