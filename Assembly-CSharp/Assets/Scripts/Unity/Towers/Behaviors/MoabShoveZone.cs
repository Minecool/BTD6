namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MoabShoveZone : TowerBehavior
{
	public MoabShoveZone parent; //Field offset: 0x98
	public float range; //Field offset: 0xA0
	public string expRange; //Field offset: 0xA8
	public float moabPushSpeedScaleCap; //Field offset: 0xB0
	public string expMoabPushSpeedScaleCap; //Field offset: 0xB8
	public float bfbPushSpeedScaleCap; //Field offset: 0xC0
	public string expBfbPushSpeedScaleCap; //Field offset: 0xC8
	public float zomgPushSpeedScaleCap; //Field offset: 0xD0
	public string expZomgPushSpeedScaleCap; //Field offset: 0xD8
	public FilterInvisible filterInvisible; //Field offset: 0xE0
	public FilterInvisible expFilterInvisible; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 339
	}

	public MoabShoveZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

