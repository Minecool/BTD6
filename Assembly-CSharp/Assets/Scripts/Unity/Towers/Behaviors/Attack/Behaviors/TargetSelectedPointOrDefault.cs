namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetSelectedPointOrDefault : TargetTypeBehavior
{
	public TargetSelectedPointOrDefault parent; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8
	public float scale; //Field offset: 0xB0
	public string expScale; //Field offset: 0xB8
	public string customName; //Field offset: 0xC0
	public string expCustomName; //Field offset: 0xC8
	public bool lockToInsideTowerRange; //Field offset: 0xD0
	public string expLockToInsideTowerRange; //Field offset: 0xD8
	public bool startWithClosestTrackPoint; //Field offset: 0xE0
	public string expStartWithClosestTrackPoint; //Field offset: 0xE8
	public GameObject displayInvalid; //Field offset: 0xF0
	public GameObject expDisplayInvalid; //Field offset: 0xF8
	public bool alwaysShowTarget; //Field offset: 0x100
	public string expAlwaysShowTarget; //Field offset: 0x108
	public Projectile projectileToExpireOnTargetChange; //Field offset: 0x110
	public Projectile expProjectileToExpireOnTargetChange; //Field offset: 0x118
	public bool dontUseTerrainHeight; //Field offset: 0x120
	public string expDontUseTerrainHeight; //Field offset: 0x128

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 412
	}

	public TargetSelectedPointOrDefault() { }

	public virtual AttackBehaviorModel get_Def() { }

}

