namespace Assets.Scripts.GameEditor.UI.PropertyFields;

public class ModelPropertyField : PropertyField
{
	public Button createGraphNodeButton; //Field offset: 0x68
	public NK_TextMeshProUGUI editableValue; //Field offset: 0x70

	public ModelPropertyField() { }

	public virtual void Initialise(GraphNode parentNode, GraphNodeModelDescriptorDef descriptor, object metadata, bool hasData) { }

	public virtual void OnPortConnected() { }

	public virtual void OnPortDisconnected() { }

}

