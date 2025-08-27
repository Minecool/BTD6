namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack;

public abstract class AttackBehavior : EntityBehavior, IAttackBehavior, IEntityBehavior
{
	public Attack attack; //Field offset: 0x60

	public AttackBehavior() { }

	public override bool CantTargetCamo() { }

	public override bool CantTargetMoab() { }

	public virtual void Cleanup() { }

	public override bool FilterTarget(Bloon bloon) { }

	public override Nullable<Single> GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void OnAnimationReadyForFire() { }

	public override bool OnlyTargetsMoab() { }

	public override void SetUpAttack() { }

	public override void ThrowCacheUpdated() { }

}

