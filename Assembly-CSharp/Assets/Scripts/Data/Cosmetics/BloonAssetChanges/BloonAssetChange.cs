namespace Assets.Scripts.Data.Cosmetics.BloonAssetChanges;

public class BloonAssetChange : AssetChangeItem
{
	public string bloonId; //Field offset: 0x20
	public List<PrefabSwap> prefabSwaps; //Field offset: 0x28

	public BloonAssetChange() { }

}

