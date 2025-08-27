namespace Assets.Scripts.Simulation.Towers.Filters;

public abstract class Filter : RootBehavior
{

	protected Filter() { }

	public override void AfterAttached(Attack attack) { }

	public override void AfterAttached(Projectile projectile) { }

	public override bool CantTargetCamo() { }

	public override bool CantTargetMoab() { }

	public override bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public override bool OnlyTargetsMoab() { }

}

