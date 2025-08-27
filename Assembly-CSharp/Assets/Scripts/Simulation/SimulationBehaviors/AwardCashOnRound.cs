namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class AwardCashOnRound : SimulationBehavior
{
	private AwardCashOnRoundModel behaviorModel; //Field offset: 0x58

	public AwardCashOnRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	private void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

