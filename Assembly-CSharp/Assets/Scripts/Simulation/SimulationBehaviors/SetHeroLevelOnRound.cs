namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class SetHeroLevelOnRound : SimulationBehavior
{
	private SetHeroLevelOnRoundModel behaviorModel; //Field offset: 0x58

	public SetHeroLevelOnRound() { }

	private bool CheckTrigger(int roundArrayIndex, out int level) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	private void PerformAction(int level) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

