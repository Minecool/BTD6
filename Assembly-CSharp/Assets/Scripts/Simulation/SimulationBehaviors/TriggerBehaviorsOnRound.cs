namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class TriggerBehaviorsOnRound : SimulationBehavior, ITriggerableBehavior
{
	private TriggerBehaviorsOnRoundModel behaviorModel; //Field offset: 0x58

	public TriggerBehaviorsOnRound() { }

	public override bool CheckForEvent(int roundArrayIndex, out int index, bool firstRound = false) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public override void PerformAction(int roundArrayIndex, int index) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

