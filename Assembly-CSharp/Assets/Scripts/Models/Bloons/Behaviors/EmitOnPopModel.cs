namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(EmitOnPop), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmitOnPopModel : BloonBehaviorModelWithTowerTracking
{
	public ProjectileModel projectile; //Field offset: 0x38
	public EmissionModel emission; //Field offset: 0x40
	public float pierceOverride; //Field offset: 0x48
	public bool ignoreSameFrameDegrade; //Field offset: 0x4C

	public EmitOnPopModel() { }

	public EmitOnPopModel(string name, ProjectileModel projectile, EmissionModel emission, float pierceOverride, bool ignoreSameFrameDegrade, ObjectId tower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

