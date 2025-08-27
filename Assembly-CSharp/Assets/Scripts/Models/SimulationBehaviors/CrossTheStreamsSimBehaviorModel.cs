namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(CrossTheStreamsSimBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CrossTheStreamsSimBehaviorModel : SimulationBehaviorModel
{
	public ProjectileModel projectileModel; //Field offset: 0x30
	public EffectModel effectModel; //Field offset: 0x38
	public int rateFrames; //Field offset: 0x40
	public EmissionModel emissionModel; //Field offset: 0x48
	public float positionRandomness; //Field offset: 0x50
	public float endPointOffset; //Field offset: 0x54

	public CrossTheStreamsSimBehaviorModel(string name, ProjectileModel projectileModel, EffectModel effectModel, int rateFrames, float positionRandomness, float endPointOffset) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

