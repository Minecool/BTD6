namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class FreeTower : SimulationBehavior
{
	public int chargesRemaining; //Field offset: 0x58
	public FreeTowerModel freeTowerModel; //Field offset: 0x60

	public FreeTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

