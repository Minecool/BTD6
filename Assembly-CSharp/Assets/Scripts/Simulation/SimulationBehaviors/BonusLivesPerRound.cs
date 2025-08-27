namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class BonusLivesPerRound : SimulationBehavior
{
	private BonusLivesPerRoundModel bonusLivesPerRoundModel; //Field offset: 0x58

	public BonusLivesPerRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

