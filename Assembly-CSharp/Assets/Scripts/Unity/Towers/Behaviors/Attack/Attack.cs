namespace Assets.Scripts.Unity.Towers.Behaviors.Attack;

public class Attack : TowerBehavior
{
	public Attack parent; //Field offset: 0x98
	public float range; //Field offset: 0xA0
	public string expRange; //Field offset: 0xA8
	public AttackBehavior targetProvider; //Field offset: 0xB0
	public AttackBehavior expTargetProvider; //Field offset: 0xB8
	public GameObject display; //Field offset: 0xC0
	public GameObject expDisplay; //Field offset: 0xC8
	public bool attackThroughWalls; //Field offset: 0xD0
	public string expAttackThroughWalls; //Field offset: 0xD8
	public bool fireWithoutTarget; //Field offset: 0xE0
	public string expFireWithoutTarget; //Field offset: 0xE8
	public int framesBeforeRetarget; //Field offset: 0xF0
	public string expFramesBeforeRetarget; //Field offset: 0xF8
	public bool addsToSharedGrid; //Field offset: 0x100
	public string expAddsToSharedGrid; //Field offset: 0x108
	public float sharedGridRange; //Field offset: 0x110
	public string expSharedGridRange; //Field offset: 0x118
	public bool drawRangeCircle; //Field offset: 0x120
	public string expDrawRangeCircle; //Field offset: 0x128

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 848
	}

	public Attack() { }

	public override GameObject Display() { }

	protected Model[] GatherBehaviors() { }

	protected WeaponModel[] GatherWeapons() { }

	public virtual TowerBehaviorModel get_Def() { }

	public bool GetFireWithoutTarget(WeaponModel[] weapons = null) { }

}

