namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BountyHunterZone : Support
{
	public BountyHunterZoneModel bountyHunterZoneModel; //Field offset: 0x90

	public BountyHunterZone() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

