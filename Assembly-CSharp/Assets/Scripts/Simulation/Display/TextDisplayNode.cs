namespace Assets.Scripts.Simulation.Display;

public class TextDisplayNode : IDisplayNode
{
	[CompilerGenerated]
	private DisplayNodeState <State>k__BackingField; //Field offset: 0x10
	public int animationState; //Field offset: 0x14
	public bool isHighlighted; //Field offset: 0x18
	public string text; //Field offset: 0x20
	public bool notLocalized; //Field offset: 0x28
	public PrefabReference objectId; //Field offset: 0x30
	public Vector3Boxed position; //Field offset: 0x38
	public FloatBoxed rotation; //Field offset: 0x40
	public int layer; //Field offset: 0x48
	public UnityDisplayNode graphic; //Field offset: 0x50

	public override UnityDisplayNode Graphic
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public override PrefabReference ObjectId
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public override DisplayNodeState State
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public TextDisplayNode() { }

	public override UnityDisplayNode get_Graphic() { }

	public override PrefabReference get_ObjectId() { }

	[CompilerGenerated]
	public override DisplayNodeState get_State() { }

	public override void set_Graphic(UnityDisplayNode value) { }

	public void set_ObjectId(PrefabReference value) { }

	[CompilerGenerated]
	public override void set_State(DisplayNodeState value) { }

}

