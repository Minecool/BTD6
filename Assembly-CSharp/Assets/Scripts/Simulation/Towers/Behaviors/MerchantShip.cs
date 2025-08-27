namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MerchantShip : TowerBehavior
{
	public MerchantShipModel merchantShipModel; //Field offset: 0x68

	public MerchantShip() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

