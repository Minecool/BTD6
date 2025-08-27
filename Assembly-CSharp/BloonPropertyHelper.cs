//Type is in global namespace

public static class BloonPropertyHelper
{
	private static readonly Dictionary<String, BloonProperties> immunitiesByDamageType; //Field offset: 0x0

	private static BloonPropertyHelper() { }

	public static bool DestroysProjectilesIfImmune(BloonProperties bloonProperties, BloonProperties immuneBloonProperties) { }

	public static BloonProperties GetBloonTypesConvertedToBloonProperties(string bloonPropertiesStr) { }

	public static BloonProperties GetDamagesTypeConvertedToImmuneBloonProperties(string damageTypesStr, string ignoreImmunityForBloonTypesStr) { }

	public static string GetDamageTypeFromImmunities(BloonProperties properties) { }

	private static BloonProperties GetDestroyProjectileFlags(BloonProperties immuneBloonProperties) { }

	public static BloonProperties GetImmunitiesFromDamageType(string damageType) { }

	private static void Log(string message) { }

}

