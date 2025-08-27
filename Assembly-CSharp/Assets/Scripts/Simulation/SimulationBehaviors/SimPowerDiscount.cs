namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class SimPowerDiscount : SimulationBehavior
{
	public int chargesRemaining; //Field offset: 0x58
	public SimPowerDiscountModel powerDiscountModel; //Field offset: 0x60

	public SimPowerDiscount() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

