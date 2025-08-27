namespace Assets.Scripts.Data.Cosmetics.TowerAssetChanges;

public class TowerAssetChange : AssetChangeItem
{
	public bool applyGlobal; //Field offset: 0x20
	public string applyTowerSets; //Field offset: 0x28
	public string towerId; //Field offset: 0x30
	public string skinId; //Field offset: 0x38
	public float delayedReveal; //Field offset: 0x40
	public List<AnimationSwap> animationSwaps; //Field offset: 0x48
	public List<PrefabSwap> prefabSwaps; //Field offset: 0x50
	public List<AudioSwap> audioSwaps; //Field offset: 0x58

	public TowerAssetChange() { }

}

