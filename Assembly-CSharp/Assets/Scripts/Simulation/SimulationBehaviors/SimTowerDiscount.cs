namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class SimTowerDiscount : SimulationBehavior
{
	public int chargesRemaining; //Field offset: 0x58
	public SimTowerDiscountModel towerDiscountModel; //Field offset: 0x60

	public SimTowerDiscount() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

