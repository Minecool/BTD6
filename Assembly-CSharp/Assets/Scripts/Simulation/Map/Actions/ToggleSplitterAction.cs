namespace Assets.Scripts.Simulation.Map.Actions;

public class ToggleSplitterAction : MapAction
{
	private ToggleSplitterActionModel toggleSplitterModel; //Field offset: 0x60

	public ToggleSplitterAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

