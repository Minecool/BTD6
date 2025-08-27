namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class PierceUpTowers : ProjectileBehavior
{
	public PierceUpTowersModel pierceUpTowersModel; //Field offset: 0x68

	public PierceUpTowers() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

