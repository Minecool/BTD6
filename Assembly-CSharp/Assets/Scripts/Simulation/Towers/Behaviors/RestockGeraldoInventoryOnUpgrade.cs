namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RestockGeraldoInventoryOnUpgrade : TowerBehavior
{
	public RestockGeraldoInventoryOnUpgradeModel restockGeraldoInventoryOnUpgradeModel; //Field offset: 0x68

	public RestockGeraldoInventoryOnUpgrade() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

