namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "CirclePattern", menuName = "BTD6/Behaviors/Attacks/CirclePattern")]
public class CirclePattern : TargetTypeBehavior
{
	public float radius; //Field offset: 0x38
	public bool reverse; //Field offset: 0x3C
	public PrefabReference display; //Field offset: 0x40
	public int displayCount; //Field offset: 0x48

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 195
	}

	public CirclePattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

