namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RetargetOnContact : ProjectileBehavior
{
	public RetargetOnContact parent; //Field offset: 0x88
	public float distance; //Field offset: 0x90
	public string expDistance; //Field offset: 0x98
	public float minDistance; //Field offset: 0xA0
	public string expMinDistance; //Field offset: 0xA8
	public int maxBounces; //Field offset: 0xB0
	public string expMaxBounces; //Field offset: 0xB8
	public string targetType; //Field offset: 0xC0
	public string expTargetType; //Field offset: 0xC8
	public float delay; //Field offset: 0xD0
	public string expDelay; //Field offset: 0xD8
	public bool expireIfNoTargetFound; //Field offset: 0xE0
	public string expExpireIfNoTargetFound; //Field offset: 0xE8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 230
	}

	public RetargetOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

