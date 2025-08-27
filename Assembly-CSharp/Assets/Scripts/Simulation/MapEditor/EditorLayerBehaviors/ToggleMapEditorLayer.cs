namespace Assets.Scripts.Simulation.MapEditor.EditorLayerBehaviors;

public class ToggleMapEditorLayer : EntityAction
{
	private ToggleMapEditorLayerModel behaviorModel; //Field offset: 0x68

	public ToggleMapEditorLayer() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	private void ToggleAreaLayer() { }

	private void TogglePropLayer() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

