namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class PatrolPointsSetting : TargetTypeBehavior
{
	public PatrolPointsSetting parent; //Field offset: 0x98
	public float pointSwitchDistance; //Field offset: 0xA0
	public string expPointSwitchDistance; //Field offset: 0xA8
	public float minimumPointDistance; //Field offset: 0xB0
	public string expMinimumPointDistance; //Field offset: 0xB8
	public float lineDelay; //Field offset: 0xC0
	public string expLineDelay; //Field offset: 0xC8
	public float dotSpacing; //Field offset: 0xD0
	public string expDotSpacing; //Field offset: 0xD8
	public float dotOffset; //Field offset: 0xE0
	public string expDotOffset; //Field offset: 0xE8
	public GameObject display; //Field offset: 0xF0
	public GameObject expDisplay; //Field offset: 0xF8
	public GameObject lineDisplay; //Field offset: 0x100
	public GameObject expLineDisplay; //Field offset: 0x108

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 361
	}

	public PatrolPointsSetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

