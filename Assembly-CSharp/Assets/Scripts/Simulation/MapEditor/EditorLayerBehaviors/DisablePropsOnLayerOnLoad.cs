namespace Assets.Scripts.Simulation.MapEditor.EditorLayerBehaviors;

public class DisablePropsOnLayerOnLoad : MapEditorLayerBehavior
{
	private DisablePropsOnLayerOnLoadModel behaviorModel; //Field offset: 0x58

	public DisablePropsOnLayerOnLoad() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

