namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class FireWhenAlternateWeaponIsReady : WeaponBehavior
{
	public FireWhenAlternateWeaponIsReadyModel fireWhenAlternateWeaponIsReadyModel; //Field offset: 0x68
	private int frameOfValidFire; //Field offset: 0x70
	private bool fireWeapon; //Field offset: 0x74

	public bool FireWeapon
	{
		 get { } //Length: 5
		 set { } //Length: 43
	}

	public FireWhenAlternateWeaponIsReady() { }

	public virtual bool CanFire() { }

	public virtual void EmissionStarted() { }

	public virtual bool FilterEmission() { }

	public bool get_FireWeapon() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public void set_FireWeapon(bool value) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

