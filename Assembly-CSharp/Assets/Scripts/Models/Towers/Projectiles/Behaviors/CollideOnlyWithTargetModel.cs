namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CollideOnlyWithTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CollideOnlyWithTargetModel : ProjectileBehaviorModel
{
	public bool collideWithFirstIfInvalidTarget; //Field offset: 0x38

	public CollideOnlyWithTargetModel(string name, bool collideWithFirstIfInvalidTarget) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

