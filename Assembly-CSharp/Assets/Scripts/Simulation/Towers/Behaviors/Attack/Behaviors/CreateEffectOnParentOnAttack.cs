namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class CreateEffectOnParentOnAttack : AttackBehavior
{
	public CreateEffectOnParentOnAttackModel createEffectOnParentOnAttackModel; //Field offset: 0x68
	private Entity activeEffect; //Field offset: 0x70

	public CreateEffectOnParentOnAttack() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

