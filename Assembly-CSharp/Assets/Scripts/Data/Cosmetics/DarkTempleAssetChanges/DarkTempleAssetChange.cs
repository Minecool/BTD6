namespace Assets.Scripts.Data.Cosmetics.DarkTempleAssetChanges;

public class DarkTempleAssetChange : AssetChangeItem
{
	public List<PrefabSwap> prefabSwaps; //Field offset: 0x20
	public List<SpriteSwap> spriteSwaps; //Field offset: 0x28

	public DarkTempleAssetChange() { }

}

