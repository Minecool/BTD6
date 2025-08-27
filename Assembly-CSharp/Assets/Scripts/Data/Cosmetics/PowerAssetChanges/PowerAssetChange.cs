namespace Assets.Scripts.Data.Cosmetics.PowerAssetChanges;

public class PowerAssetChange : AssetChangeItem
{
	public string powerId; //Field offset: 0x20
	public List<PrefabSwap> prefabSwaps; //Field offset: 0x28
	public List<SpriteSwap> spriteSwaps; //Field offset: 0x30
	public List<AudioSwap> audioSwaps; //Field offset: 0x38
	public List<PrefabArraySwap> prefabArraySwaps; //Field offset: 0x40

	public PowerAssetChange() { }

}

