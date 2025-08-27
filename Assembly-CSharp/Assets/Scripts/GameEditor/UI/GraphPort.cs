namespace Assets.Scripts.GameEditor.UI;

public class GraphPort : MonoBehaviour
{
	public NK_TextMeshProUGUI nameTxt; //Field offset: 0x20
	[CompilerGenerated]
	private string <PortName>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GraphNode <ParentNode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private GraphNode <Connection>k__BackingField; //Field offset: 0x38
	private GraphNodeModelDescriptorDef _descriptor; //Field offset: 0x40

	public private GraphNode Connection
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GraphNodeModelDescriptorDef Descriptor
	{
		 get { } //Length: 124
	}

	public private GraphNode ParentNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private string PortName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Type Type
	{
		 get { } //Length: 35
	}

	public GraphPort() { }

	public void Connect(GraphNode otherNode) { }

	public void Disconnect() { }

	public void DisconnectInput() { }

	public void DisconnectOutput() { }

	[CompilerGenerated]
	public GraphNode get_Connection() { }

	public GraphNodeModelDescriptorDef get_Descriptor() { }

	[CompilerGenerated]
	public GraphNode get_ParentNode() { }

	[CompilerGenerated]
	public string get_PortName() { }

	public Type get_Type() { }

	public override void Initialise(GraphNode parentNode, GraphNodeModelDescriptorDef descriptor) { }

	public override void OnPortConnected() { }

	public override void OnPortDisconnected() { }

	public void OnUpdateState() { }

	[CompilerGenerated]
	private void set_Connection(GraphNode value) { }

	[CompilerGenerated]
	private void set_ParentNode(GraphNode value) { }

	[CompilerGenerated]
	private void set_PortName(string value) { }

}

