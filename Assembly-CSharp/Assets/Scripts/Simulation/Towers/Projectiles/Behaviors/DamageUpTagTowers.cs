namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageUpTagTowers : ProjectileBehavior
{
	public DamageUpTagTowersModel damageUpTagTowersModel; //Field offset: 0x68

	public DamageUpTagTowers() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

