namespace NinjaKiwi.Common.ResourceUtils;

public class AssetManifest
{
	public Dictionary<String, Resource> assets; //Field offset: 0x10
	public Dictionary<String, Resource> atlases; //Field offset: 0x18

	public AssetManifest() { }

}

