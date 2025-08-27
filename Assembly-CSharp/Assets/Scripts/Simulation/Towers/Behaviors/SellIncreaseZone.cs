namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SellIncreaseZone : TowerBehavior
{
	public SellIncreaseZoneModel sellIncreaseZoneModel; //Field offset: 0x68
	private List<RootBehavior> createdBehaviors; //Field offset: 0x70

	public SellIncreaseZone() { }

	public bool CheckBehavior(Tower tower) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

