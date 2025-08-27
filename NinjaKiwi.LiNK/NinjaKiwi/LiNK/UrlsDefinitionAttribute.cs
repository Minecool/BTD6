namespace NinjaKiwi.LiNK;

internal sealed class UrlsDefinitionAttribute : Attribute
{
	public string api; //Field offset: 0x10
	public string cdn; //Field offset: 0x18
	public string webview; //Field offset: 0x20
	public string priority; //Field offset: 0x28

	public UrlsDefinitionAttribute() { }

}

