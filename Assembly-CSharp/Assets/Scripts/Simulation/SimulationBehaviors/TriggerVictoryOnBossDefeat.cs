namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class TriggerVictoryOnBossDefeat : SimulationBehavior
{
	public TriggerVictoryOnBossDefeatModel behaviorModel; //Field offset: 0x58

	public TriggerVictoryOnBossDefeat() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnMatchReady(bool loadedSave) { }

	private void TriggerVictory(int tier) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

