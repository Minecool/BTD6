namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DestroyWhenHitImmune), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyWhenHitImmuneModel : ProjectileBehaviorModel
{
	public bool getsDestroyed; //Field offset: 0x38

	public DestroyWhenHitImmuneModel(string name, bool getsDestroyed) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

