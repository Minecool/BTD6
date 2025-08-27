namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddbehaviorToWeapon : ProjectileBehavior
{
	public AddbehaviorToWeaponModel addBehaviorToWeaponModel; //Field offset: 0x68

	public AddbehaviorToWeapon() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

