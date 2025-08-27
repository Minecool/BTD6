namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class FreeUpgradeSupport : Support
{
	public FreeUpgradeSupportModel freeUpgradeSupportModel; //Field offset: 0x90

	public FreeUpgradeSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

