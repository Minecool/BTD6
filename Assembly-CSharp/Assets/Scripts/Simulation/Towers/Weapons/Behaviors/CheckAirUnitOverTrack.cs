namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CheckAirUnitOverTrack : WeaponBehavior
{
	public CheckAirUnitOverTrackModel airUnitOverTrackModel; //Field offset: 0x68
	private AirUnit airUnit; //Field offset: 0x70

	public CheckAirUnitOverTrack() { }

	public virtual bool FilterEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

