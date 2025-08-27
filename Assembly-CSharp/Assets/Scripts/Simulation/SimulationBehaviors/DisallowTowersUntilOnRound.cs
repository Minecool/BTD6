namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class DisallowTowersUntilOnRound : SimulationBehavior
{
	private DisallowTowersUntilOnRoundModel behaviorModel; //Field offset: 0x58

	private bool IsTriggeredOrPastTriggerRound
	{
		private get { } //Length: 53
	}

	private bool ShouldTriggerBeforeNextRoundStarts
	{
		private get { } //Length: 56
	}

	public DisallowTowersUntilOnRound() { }

	private void DisallowAllTowers(bool value) { }

	private bool get_IsTriggeredOrPastTriggerRound() { }

	private bool get_ShouldTriggerBeforeNextRoundStarts() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

