namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class CirclePattern : TargetTypeBehavior
{
	public CirclePattern parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8
	public bool reverse; //Field offset: 0xB0
	public string expReverse; //Field offset: 0xB8
	public GameObject display; //Field offset: 0xC0
	public GameObject expDisplay; //Field offset: 0xC8
	public int displayCount; //Field offset: 0xD0
	public string expDisplayCount; //Field offset: 0xD8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 266
	}

	public CirclePattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

