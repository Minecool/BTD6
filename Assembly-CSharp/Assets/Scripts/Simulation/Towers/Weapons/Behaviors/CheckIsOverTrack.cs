namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class CheckIsOverTrack : WeaponBehavior
{
	public CheckIsOverTrackModel checkIsOverTrackModel; //Field offset: 0x68

	public CheckIsOverTrack() { }

	public virtual bool FilterEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

