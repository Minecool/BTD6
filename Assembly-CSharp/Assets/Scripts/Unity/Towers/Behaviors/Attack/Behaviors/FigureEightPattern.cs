namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class FigureEightPattern : TargetTypeBehavior
{
	public FigureEightPattern parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8
	public bool rotated; //Field offset: 0xB0
	public string expRotated; //Field offset: 0xB8
	public GameObject display; //Field offset: 0xC0
	public GameObject expDisplay; //Field offset: 0xC8
	public int displayCount; //Field offset: 0xD0
	public string expDisplayCount; //Field offset: 0xD8
	public bool dontUseTowerPosition; //Field offset: 0xE0
	public string expDontUseTowerPosition; //Field offset: 0xE8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 280
	}

	public FigureEightPattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

