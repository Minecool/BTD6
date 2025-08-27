namespace Assets.Scripts.Unity.MapEditor.EditorLayerBehaviors;

public class DisablePropsOnLayerOnLoad : MapEditorLayerBehavior
{

	public virtual MapEditorLayerBehaviorModel Def
	{
		 get { } //Length: 86
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public DisablePropsOnLayerOnLoad() { }

	public DisablePropsOnLayerOnLoad(int layerId) { }

	public virtual MapEditorLayerBehaviorModel get_Def() { }

	public virtual string get_Type() { }

	public virtual bool IsEqual(MapEditorLayerBehavior other) { }

}

