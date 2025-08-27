namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TravelTowardsEmitTower : ProjectileBehavior
{
	public TravelStrait parent; //Field offset: 0x88
	public bool lockRotation; //Field offset: 0x90
	public string expLockRotation; //Field offset: 0x98
	public float speed; //Field offset: 0xA0
	public string expSpeed; //Field offset: 0xA8
	public float range; //Field offset: 0xB0
	public string expRange; //Field offset: 0xB8
	public bool delayedActivation; //Field offset: 0xC0
	public string expDelayedActivation; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 184
	}

	public TravelTowardsEmitTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

