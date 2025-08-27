namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class CashRushGameMode : SimulationBehavior
{
	public CashRushGameModeModel cashRushGameModeModel; //Field offset: 0x58

	public CashRushGameMode() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public void Process(int ellapsed) { }

	private void TriggerVictory(int playerIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

