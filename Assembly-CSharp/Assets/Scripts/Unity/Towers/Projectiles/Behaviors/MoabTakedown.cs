namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class MoabTakedown : ProjectileBehavior
{
	public MoabTakedown parent; //Field offset: 0x88
	public float speed; //Field offset: 0x90
	public string expSpeed; //Field offset: 0x98
	public float addative; //Field offset: 0xA0
	public string expAddative; //Field offset: 0xA8
	public float multiplier; //Field offset: 0xB0
	public string expMultiplier; //Field offset: 0xB8
	public bool increaseMoabBloonWorth; //Field offset: 0xC0
	public string expIncreaseMoabBloonWorth; //Field offset: 0xC8
	public IncreaseWorthTextEffect increaseWorthTextEffect; //Field offset: 0xD0
	public IncreaseWorthTextEffect expIncreaseWorthTextEffect; //Field offset: 0xD8
	public float destroyBloonRadius; //Field offset: 0xE0
	public string expDestroyBloonRadius; //Field offset: 0xE8
	public GameObject displayAtEject; //Field offset: 0xF0
	public GameObject expDisplayAtEject; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 440
	}

	public MoabTakedown() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

