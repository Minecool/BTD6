namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RangeUpTowers : ProjectileBehavior
{
	public RangeUpTowersModel rangeUpTowersModel; //Field offset: 0x68

	public RangeUpTowers() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

