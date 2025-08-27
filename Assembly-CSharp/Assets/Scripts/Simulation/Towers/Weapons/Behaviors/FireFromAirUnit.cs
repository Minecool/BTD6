namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class FireFromAirUnit : WeaponBehavior
{
	public FireFromAirUnitModel emissionsPerRoundFilterModel; //Field offset: 0x68
	private AirUnit airUnit; //Field offset: 0x70

	public FireFromAirUnit() { }

	public virtual Nullable<Vector3> EmitPosition() { }

	public virtual Nullable<Single> EmitRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

