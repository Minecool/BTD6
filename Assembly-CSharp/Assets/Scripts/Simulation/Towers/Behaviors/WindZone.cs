namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class WindZone : TowerBehavior
{
	public WindZoneModel windZoneModel; //Field offset: 0x68
	private int bloonIndex; //Field offset: 0x70
	private List<RootBehavior> createdBehaviors; //Field offset: 0x78

	public WindZone() { }

	private void BloonEnter(Bloon bloon) { }

	private void BloonExit(Bloon bloon) { }

	public bool CheckFilters(RootBehavior behavior) { }

	public float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

