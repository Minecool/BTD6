namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerSell : TowerBehavior
{
	public TowerSellModel towerSellModel; //Field offset: 0x68
	private int chargesRemaining; //Field offset: 0x70

	public TowerSell() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSold(float amount) { }

	public virtual float TransformSalePerc() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

