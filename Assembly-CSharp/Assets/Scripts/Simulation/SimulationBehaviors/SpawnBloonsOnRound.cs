namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class SpawnBloonsOnRound : SimulationBehavior
{
	private SpawnBloonsOnRoundModel behaviorModel; //Field offset: 0x58
	private BloonModel bloonModelToSpawn; //Field offset: 0x60
	private bool isSpawned; //Field offset: 0x68

	public SpawnBloonsOnRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void OnRoundStart(int roundArrayIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

