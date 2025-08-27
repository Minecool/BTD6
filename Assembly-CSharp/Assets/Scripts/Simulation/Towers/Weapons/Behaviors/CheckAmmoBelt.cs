namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CheckAmmoBelt : WeaponBehavior
{
	public CheckAmmoBeltModel ammoBeltModel; //Field offset: 0x68
	private float lastFire; //Field offset: 0x70

	public CheckAmmoBelt() { }

	public virtual void EmissionStarted() { }

	public virtual bool FilterEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

