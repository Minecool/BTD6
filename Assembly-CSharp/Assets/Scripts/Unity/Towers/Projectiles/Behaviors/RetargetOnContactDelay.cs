namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RetargetOnContactDelay : ProjectileBehavior
{
	public RetargetOnContactDelay parent; //Field offset: 0x88
	public float distance; //Field offset: 0x90
	public string expDistance; //Field offset: 0x98
	public int maxBounces; //Field offset: 0xA0
	public string expMaxBounces; //Field offset: 0xA8
	public float delay; //Field offset: 0xB0
	public string expDelay; //Field offset: 0xB8
	public bool onlyIfFirstBloonDestroyed; //Field offset: 0xC0
	public string expOnlyIfFirstBloonDestroyed; //Field offset: 0xC8
	public GameObject display; //Field offset: 0xD0
	public GameObject expDisplay; //Field offset: 0xD8
	public float displayLifetime; //Field offset: 0xE0
	public string expDisplayLifetime; //Field offset: 0xE8
	public float displayLengthScale; //Field offset: 0xF0
	public string expDisplayLengthScale; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 504
	}

	public RetargetOnContactDelay() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

