namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CheckAdoraCanFire : WeaponBehavior
{
	public CheckAdoraCanFireModel checkAdoraCanFireModel; //Field offset: 0x68

	public CheckAdoraCanFire() { }

	public virtual bool CanFire() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

