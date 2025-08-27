namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SupportTowerPlacementZone : Support
{
	public SupportTowerPlacementZoneModel supportTowerPlacementZoneModel; //Field offset: 0x90

	public SupportTowerPlacementZone() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

