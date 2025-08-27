namespace NinjaKiwi.Common.ResourceUtils;

[AttributeUsage(AttributeTargets::Field (256))]
public class AssetNameAttribute : PropertyAttribute
{
	public const char kSeparator = '\u2C'; //Field offset: 0x0
	public Type objType; //Field offset: 0x18

	public AssetNameAttribute(Type objType) { }

	public static string AssetName(string input) { }

}

