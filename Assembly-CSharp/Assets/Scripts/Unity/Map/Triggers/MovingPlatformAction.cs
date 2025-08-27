namespace Assets.Scripts.Unity.Map.Triggers;

public class MovingPlatformAction : MapAction
{
	public Area[] areasToMove; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28
	public AnimationClip animClip; //Field offset: 0x30
	public int startingState; //Field offset: 0x38
	public Int32[] triggerNumToStateNum; //Field offset: 0x40
	public Single[] stateTimes; //Field offset: 0x48
	[Tooltip("Will be filled in automatically when you save the map")]
	public AnimationCurve xPosCurve; //Field offset: 0x50
	[Tooltip("Will be filled in automatically when you save the map")]
	public AnimationCurve zPosCurve; //Field offset: 0x58
	[Tooltip("Will be filled in automatically when you save the map")]
	public AnimationCurve yRotCurve; //Field offset: 0x60
	private MovingPlatformActionModel def; //Field offset: 0x68

	public virtual MapActionModel Def
	{
		 get { } //Length: 601
	}

	public MovingPlatformAction() { }

	public virtual MapActionModel get_Def() { }

}

