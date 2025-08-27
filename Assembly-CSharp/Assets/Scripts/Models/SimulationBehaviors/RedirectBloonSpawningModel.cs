namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(RedirectBloonSpawning), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RedirectBloonSpawningModel : SimulationBehaviorModel
{
	public float duration; //Field offset: 0x30
	public int durationFrames; //Field offset: 0x34
	public int rounds; //Field offset: 0x38
	public PrefabReference portalAsset; //Field offset: 0x40
	public EffectModel portalExpiryEffect; //Field offset: 0x48

	public RedirectBloonSpawningModel(string name, float duration, int rounds, PrefabReference portalAsset, EffectModel portalExpiryEffect) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

