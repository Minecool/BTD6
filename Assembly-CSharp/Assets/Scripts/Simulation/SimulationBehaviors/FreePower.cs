namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class FreePower : SimulationBehavior
{
	public int chargesRemaining; //Field offset: 0x58
	public FreePowerModel freePowerModel; //Field offset: 0x60

	public FreePower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

