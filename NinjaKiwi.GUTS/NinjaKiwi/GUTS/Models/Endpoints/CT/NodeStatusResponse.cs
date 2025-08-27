namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class NodeStatusResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private NodeStatus <NodeStatus>k__BackingField; //Field offset: 0x18

	public NodeStatus NodeStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public NodeStatusResponse() { }

	[CompilerGenerated]
	public NodeStatus get_NodeStatus() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_NodeStatus(NodeStatus value) { }

}

