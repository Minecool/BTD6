namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class FireAlternateWeapon : WeaponBehavior
{
	public FireAlternateWeaponModel fireAlternateWeaponModel; //Field offset: 0x68
	private FireWhenAlternateWeaponIsReady behavior; //Field offset: 0x70

	public FireAlternateWeapon() { }

	public virtual void EmissionStarted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

