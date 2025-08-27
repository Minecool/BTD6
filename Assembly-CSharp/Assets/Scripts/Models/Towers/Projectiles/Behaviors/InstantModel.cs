namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Instant), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class InstantModel : ProjectileBehaviorModel
{
	public bool destroyIfInvalid; //Field offset: 0x38
	public bool ignoreTargetZ; //Field offset: 0x39
	public bool dontFollowTarget; //Field offset: 0x3A

	public InstantModel(string name, bool destroyIfInvalid, bool ignoreTargetZ, bool dontFollowTarget) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

