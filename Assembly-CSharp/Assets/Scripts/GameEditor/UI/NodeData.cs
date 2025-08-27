namespace Assets.Scripts.GameEditor.UI;

public class NodeData
{
	public string NodeType; //Field offset: 0x10
	public Vector2 Position; //Field offset: 0x18
	public Dictionary<String, Object> Properties; //Field offset: 0x20

	public NodeData() { }

}

