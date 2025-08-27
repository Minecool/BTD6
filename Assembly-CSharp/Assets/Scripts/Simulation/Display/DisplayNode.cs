namespace Assets.Scripts.Simulation.Display;

public class DisplayNode : IDisplayNode
{
	[CompilerGenerated]
	private DisplayNodeState <State>k__BackingField; //Field offset: 0x10
	private int animationState; //Field offset: 0x14
	[CompilerGenerated]
	private bool <AnimationEnabled>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <AnimationSpeed>k__BackingField; //Field offset: 0x1C
	private List<Int32> stateTriggers; //Field offset: 0x20
	private List<String> animTriggers; //Field offset: 0x28
	private List<String> showOverlays; //Field offset: 0x30
	private PrefabReference objectId; //Field offset: 0x38
	public float delayTillReveal; //Field offset: 0x40
	public bool isActive; //Field offset: 0x44
	public bool isHilighted; //Field offset: 0x45
	public Fullscreen fullscreen; //Field offset: 0x48
	public Vector3Boxed position; //Field offset: 0x50
	public FloatBoxed rotation; //Field offset: 0x58
	public Quaternion rotationQuat; //Field offset: 0x60
	public Mesh mesh; //Field offset: 0x70
	public int layer; //Field offset: 0x78
	public int groupId; //Field offset: 0x7C
	public bool flipLayers; //Field offset: 0x80
	public float transparency; //Field offset: 0x84
	public bool modifyColor; //Field offset: 0x88
	public float colorRed; //Field offset: 0x8C
	public float colorGreen; //Field offset: 0x90
	public float colorBlue; //Field offset: 0x94
	public List<AnimationChange> animationChanges; //Field offset: 0x98
	public UnityDisplayNode graphic; //Field offset: 0xA0

	public bool Active
	{
		 get { } //Length: 20
	}

	public bool AnimationEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float AnimationSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public int AnimationState
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public List<String> AnimTriggers
	{
		 get { } //Length: 5
	}

	public override UnityDisplayNode Graphic
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public bool HasOverriddenRotation
	{
		 get { } //Length: 127
	}

	public override PrefabReference ObjectId
	{
		 get { } //Length: 5
		 set { } //Length: 54
	}

	public List<String> ShowOverlays
	{
		 get { } //Length: 5
	}

	public override DisplayNodeState State
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public List<Int32> StateTriggers
	{
		 get { } //Length: 5
	}

	public DisplayNode() { }

	public void AddOverlaysToShow(String[] overlayIds) { }

	public void ClearAnimTriggers() { }

	public void ClearOverlays() { }

	public void ClearTriggers() { }

	public bool get_Active() { }

	[CompilerGenerated]
	public bool get_AnimationEnabled() { }

	[CompilerGenerated]
	public float get_AnimationSpeed() { }

	public int get_AnimationState() { }

	public List<String> get_AnimTriggers() { }

	public override UnityDisplayNode get_Graphic() { }

	public bool get_HasOverriddenRotation() { }

	public override PrefabReference get_ObjectId() { }

	public List<String> get_ShowOverlays() { }

	[CompilerGenerated]
	public override DisplayNodeState get_State() { }

	public List<Int32> get_StateTriggers() { }

	public void ResetOverriddenRotation() { }

	[CompilerGenerated]
	public void set_AnimationEnabled(bool value) { }

	[CompilerGenerated]
	public void set_AnimationSpeed(float value) { }

	public void set_AnimationState(int value) { }

	public override void set_Graphic(UnityDisplayNode value) { }

	public void set_ObjectId(PrefabReference value) { }

	[CompilerGenerated]
	public override void set_State(DisplayNodeState value) { }

	public void SetAnimTrigger(string triggerID) { }

	public void SetTrigger(int triggerID) { }

}

