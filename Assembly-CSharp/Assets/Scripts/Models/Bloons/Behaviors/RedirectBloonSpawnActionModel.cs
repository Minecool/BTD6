namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(RedirectBloonSpawnAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RedirectBloonSpawnActionModel : BloonBehaviorActionModel
{
	public float duration; //Field offset: 0x38
	public int rounds; //Field offset: 0x3C
	public int durationFrames; //Field offset: 0x40
	public PrefabReference portalAsset; //Field offset: 0x48
	public bool rotatePortalToBloon; //Field offset: 0x50
	public EffectModel portalExpiryEffect; //Field offset: 0x58
	public RedirectBloonSpawningModel redirectBloonSpawningModel; //Field offset: 0x60

	public RedirectBloonSpawnActionModel() { }

	public RedirectBloonSpawnActionModel(string name, float duration, int rounds, PrefabReference portalAsset, string actionId, bool rotatePortalToBloon, EffectModel portalExpiryEffect) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

