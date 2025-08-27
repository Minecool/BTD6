namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "Attack", menuName = "BTD6/Behaviors/Attack Asset", order = 1)]
public class Attack : TowerBehavior
{
	public float range; //Field offset: 0x30
	public bool attackThroughWalls; //Field offset: 0x34
	public bool fireWithoutTarget; //Field offset: 0x35
	public int framesBeforeRetarget; //Field offset: 0x38
	public bool addsToSharedGrid; //Field offset: 0x3C
	public float sharedGridRange; //Field offset: 0x40
	public bool drawRangeCircle; //Field offset: 0x44
	[UIVariableHidden]
	public PrefabReference display; //Field offset: 0x48
	[JsonConverter(typeof(BehaviorConverter))]
	public AttackBehavior targetProvider; //Field offset: 0x50
	[JsonConverter(typeof(BehaviorConverter))]
	public Weapon[] weapons; //Field offset: 0x58
	[JsonConverter(typeof(BehaviorConverter))]
	public AttackBehavior[] behaviors; //Field offset: 0x60
	[JsonConverter(typeof(BehaviorConverter))]
	public OffsetPosition ejectPosition; //Field offset: 0x68

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 651
	}

	public Attack() { }

	public virtual TowerBehaviorModel get_Def() { }

}

