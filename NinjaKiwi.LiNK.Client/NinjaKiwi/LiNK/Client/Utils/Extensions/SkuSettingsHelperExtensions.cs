namespace NinjaKiwi.LiNK.Client.Utils.Extensions;

[Extension]
public static class SkuSettingsHelperExtensions
{

	[Extension]
	public static string GetSkuJsonFromData(SkuSettingsHelper skuSettingsHelper, Byte[] data) { }

	[Extension]
	public static string GetSkuRedirectsUrlByBuild(SkuSettingsHelper skuSettingsHelper) { }

	[Extension]
	public static string GetSkuUrlFromRedirects(SkuSettingsHelper skuSettingsHelper, Byte[] bytes, String[] buildNames) { }

}

