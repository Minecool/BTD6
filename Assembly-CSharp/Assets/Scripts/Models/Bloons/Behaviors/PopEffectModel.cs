namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(PopEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PopEffectModel : BloonBehaviorModel
{
	public PrefabReference displayAssetId; //Field offset: 0x30
	public AudioClipReference soundEffect1Id; //Field offset: 0x38
	public AudioClipReference soundEffect2Id; //Field offset: 0x40
	public AudioClipReference soundEffect3Id; //Field offset: 0x48
	public AudioClipReference soundEffect4Id; //Field offset: 0x50
	public string soundEffectGroupID; //Field offset: 0x58
	public int soundEffectGroupLimit; //Field offset: 0x60
	public int soundEffectTimeDelay; //Field offset: 0x64
	public int soundEffectTimeDelayFF; //Field offset: 0x68

	public PopEffectModel() { }

	public PopEffectModel(string name, PrefabReference displayAssetId, AudioClipReference soundEffect1Id, AudioClipReference soundEffect2Id, AudioClipReference soundEffect3Id, AudioClipReference soundEffect4Id, string soundEffectGroupID, int soundEffectGroupLimit, int soundEffectTimeDelay, int soundEffectTimeDelayFF) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

