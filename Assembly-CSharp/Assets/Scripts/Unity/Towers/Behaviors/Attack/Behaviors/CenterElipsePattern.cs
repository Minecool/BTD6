namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class CenterElipsePattern : TargetTypeBehavior
{
	public CenterElipsePattern parent; //Field offset: 0x98
	public float widthRadius; //Field offset: 0xA0
	public string expWidthRadius; //Field offset: 0xA8
	public float heightRadius; //Field offset: 0xB0
	public string expHeightRadius; //Field offset: 0xB8
	public bool reverse; //Field offset: 0xC0
	public string expReverse; //Field offset: 0xC8
	public GameObject display; //Field offset: 0xD0
	public GameObject expDisplay; //Field offset: 0xD8
	public int displayCount; //Field offset: 0xE0
	public string expDisplayCount; //Field offset: 0xE8
	public bool canSelectPoint; //Field offset: 0xF0
	public string expCanSelectPoint; //Field offset: 0xF8
	public GameObject pointDisplay; //Field offset: 0x100
	public GameObject expPointDisplay; //Field offset: 0x108

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 316
	}

	public CenterElipsePattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

