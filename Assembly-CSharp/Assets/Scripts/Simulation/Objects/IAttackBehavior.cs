namespace Assets.Scripts.Simulation.Objects;

public interface IAttackBehavior : IEntityBehavior
{

	public bool CantTargetCamo() { }

	public bool CantTargetMoab() { }

	public bool FilterTarget(Bloon bloon) { }

	public Nullable<Single> GetRange() { }

	public void OnAnimationReadyForFire() { }

	public bool OnlyTargetsMoab() { }

	public void SetUpAttack() { }

	public void ThrowCacheUpdated() { }

}

