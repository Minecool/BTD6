namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DestroyProjectileIfModelChanged), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyProjectileIfModelChangedModel : ProjectileBehaviorModel
{

	public DestroyProjectileIfModelChangedModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

