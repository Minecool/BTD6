namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class ShieldPerRound : SimulationBehavior
{
	private ShieldPerRoundModel shieldModel; //Field offset: 0x58

	public ShieldPerRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRoundStart(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

