namespace Assets.Scripts.GameEditor.UI;

public class SpriteRefPropertyField : PropertyField
{
	public Image image; //Field offset: 0x68

	public SpriteRefPropertyField() { }

	public virtual void Initialise(GraphNode parentNode, GraphNodeModelDescriptorDef descriptor, object metadata, bool hasData) { }

}

