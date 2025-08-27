namespace Assets.Scripts.Data.Cosmetics.BloonPopFXs;

public class BloonPopFX : AssetChangeItem
{
	public bool applyGlobal; //Field offset: 0x20
	public string bloonIds; //Field offset: 0x28
	public PrefabReference popFX; //Field offset: 0x30
	public AudioClipReference popSound1; //Field offset: 0x38
	public AudioClipReference popSound2; //Field offset: 0x40
	public AudioClipReference popSound3; //Field offset: 0x48
	public AudioClipReference popSound4; //Field offset: 0x50
	public int soundEffectTimeDelay; //Field offset: 0x58
	public int soundEffectTimeDelayFF; //Field offset: 0x5C

	public BloonPopFX() { }

}

