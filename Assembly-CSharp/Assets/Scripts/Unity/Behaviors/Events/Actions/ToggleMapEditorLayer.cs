namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class ToggleMapEditorLayer : EntityAction
{
	[SerializeField]
	public int layerId; //Field offset: 0x18
	[SerializeField]
	public LayerType layerType; //Field offset: 0x1C
	[SerializeField]
	public bool isVisible; //Field offset: 0x20

	public virtual Model Model
	{
		 get { } //Length: 126
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ToggleMapEditorLayer() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

