namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SpiritTowerSupport : TowerBehavior
{
	private SpiritTowerSupportModel supportModel; //Field offset: 0x68

	public SpiritTowerSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

