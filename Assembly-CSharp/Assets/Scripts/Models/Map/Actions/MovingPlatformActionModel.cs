namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(MovingPlatformAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MovingPlatformActionModel : MapActionModel
{
	public String[] areaNames; //Field offset: 0x38
	public Animator animator; //Field offset: 0x40
	public AnimationClip animClip; //Field offset: 0x48
	public int startingState; //Field offset: 0x50
	public Int32[] triggerNumToStateNum; //Field offset: 0x58
	public Single[] stateTimes; //Field offset: 0x60
	public AnimationCurve xPosCurve; //Field offset: 0x68
	public AnimationCurve zPosCurve; //Field offset: 0x70
	public AnimationCurve yRotCurve; //Field offset: 0x78

	public MovingPlatformActionModel(string name, String[] areaNames, Animator animator, AnimationClip animClip, int startingState, Int32[] triggerNumToStateNum, Single[] stateTimes, AnimationCurve xPosCurve, AnimationCurve zPosCurve, AnimationCurve yRotCurve) { }

}

