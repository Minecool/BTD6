namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SwitchTargetSupplierOnUpgrade : TowerBehavior
{
	public SwitchTargetSupplierOnUpgradeModel switchTargetSupplierOnUpgradeModel; //Field offset: 0x68

	public SwitchTargetSupplierOnUpgrade() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

