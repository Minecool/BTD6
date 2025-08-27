namespace Assets.Scripts.Simulation.Towers.Projectiles;

public interface IProjectileBehavior : IEntityBehavior
{

	public bool CantHitCamo() { }

	public bool CantHitMoab() { }

	public bool OnlyHitMoab() { }

}

