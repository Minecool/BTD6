namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "PatrolPointsSetting", menuName = "BTD6/Behaviors/Attacks/PatrolPointsSetting")]
public class PatrolPointsSetting : TargetTypeBehavior
{
	public float pointSwitchDistance; //Field offset: 0x38
	public float minimumPointDistance; //Field offset: 0x3C
	public float lineDelay; //Field offset: 0x40
	public float dotSpacing; //Field offset: 0x44
	public float dotOffset; //Field offset: 0x48
	public PrefabReference display; //Field offset: 0x50
	public PrefabReference lineDisplay; //Field offset: 0x58

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 272
	}

	public PatrolPointsSetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

