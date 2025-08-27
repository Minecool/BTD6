namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class UpgradeTowerOnRound : SimulationTriggerBehavior
{
	private UpgradeTowerOnRoundModel behaviorModel; //Field offset: 0x58

	public UpgradeTowerOnRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundEnd(int roundIndex) { }

	public virtual void OnTriggerActivated(String[] triggers, int round = -1) { }

	public void PerformAction(UpgradeTowerOnRoundData upgradeData) { }

	public virtual void PerformTrigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

