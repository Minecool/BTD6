namespace Assets.Scripts.Data.Cosmetics.BloonDecals;

public class BloonDecal : AssetChangeItem
{
	public int layer; //Field offset: 0x20
	public List<BloonDecalSwap> bloonOverlayLayers; //Field offset: 0x28

	public BloonDecal() { }

}

