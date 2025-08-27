namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class FighterPilotPatternLast : TargetTypeBehavior
{
	public FighterPilotPatternLast parent; //Field offset: 0x98
	public float offsetDistance; //Field offset: 0xA0
	public string expOffsetDistance; //Field offset: 0xA8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 163
	}

	public FighterPilotPatternLast() { }

	public virtual AttackBehaviorModel get_Def() { }

}

