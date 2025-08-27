namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(EmitOnDestroy), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmitOnDestroyModel : BloonBehaviorModelWithTowerTracking
{
	public ProjectileModel projectile; //Field offset: 0x38
	public EmissionModel emission; //Field offset: 0x40
	public EffectModel effectModel; //Field offset: 0x48
	public SoundModel sound1; //Field offset: 0x50
	public SoundModel sound2; //Field offset: 0x58

	public EmitOnDestroyModel() { }

	public EmitOnDestroyModel(string name, ProjectileModel projectile, EmissionModel emission, EffectModel effectModel, ObjectId tower, SoundModel sound1, SoundModel sound2) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

