namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "CenterElipsePattern", menuName = "BTD6/Behaviors/Attacks/CenterElipsePattern")]
public class CenterElipsePattern : TargetTypeBehavior
{
	public float widthRadius; //Field offset: 0x38
	public float heightRadius; //Field offset: 0x3C
	public bool reverse; //Field offset: 0x40
	public PrefabReference display; //Field offset: 0x48
	public int displayCount; //Field offset: 0x50
	public bool canSelectPoint; //Field offset: 0x54
	public PrefabReference pointDisplay; //Field offset: 0x58

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 230
	}

	public CenterElipsePattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

