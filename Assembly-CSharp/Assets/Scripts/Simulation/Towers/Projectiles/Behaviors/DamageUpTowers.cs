namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageUpTowers : ProjectileBehavior
{
	public DamageUpTowersModel damageUpTowersModel; //Field offset: 0x68

	public DamageUpTowers() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

