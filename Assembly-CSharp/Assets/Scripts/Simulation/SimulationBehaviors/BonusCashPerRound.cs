namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class BonusCashPerRound : SimulationBehavior
{
	public BonusCashPerRoundModel bonusCashPerRoundModel; //Field offset: 0x58

	public BonusCashPerRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

