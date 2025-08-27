namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class WeaponRateMin : WeaponBehavior
{
	public WeaponRateMinModel weaponRateMinModel; //Field offset: 0x68

	public WeaponRateMin() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

