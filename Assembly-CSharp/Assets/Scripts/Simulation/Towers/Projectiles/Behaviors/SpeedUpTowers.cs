namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SpeedUpTowers : ProjectileBehavior
{
	public SpeedUpTowersModel speedUpTowersModel; //Field offset: 0x68

	public SpeedUpTowers() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

