namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class PreGamePrep : SimulationBehavior
{
	private PreGamePrepModel prepModel; //Field offset: 0x58

	public PreGamePrep() { }

	private void AddRoadSpikesToEndOfTrack() { }

	private void CreateSpikesAtPosition(Vector3 location) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

