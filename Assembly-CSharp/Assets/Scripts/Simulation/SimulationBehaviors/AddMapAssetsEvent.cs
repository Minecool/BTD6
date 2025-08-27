namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class AddMapAssetsEvent : SimulationBehavior
{
	private AddMapAssetsEventModel behaviorModel; //Field offset: 0x58

	public AddMapAssetsEvent() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	private void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

