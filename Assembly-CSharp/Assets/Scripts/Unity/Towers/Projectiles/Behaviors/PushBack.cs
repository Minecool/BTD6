namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class PushBack : ProjectileBehavior
{
	public PushBack parent; //Field offset: 0x88
	public float pushAmount; //Field offset: 0x90
	public string expPushAmount; //Field offset: 0x98
	public string tagValue; //Field offset: 0xA0
	public string expTagValue; //Field offset: 0xA8
	public float multiplierMOAB; //Field offset: 0xB0
	public string expMultiplierMOAB; //Field offset: 0xB8
	public float multiplierBFB; //Field offset: 0xC0
	public string expMultiplierBFB; //Field offset: 0xC8
	public float multiplierDDT; //Field offset: 0xD0
	public string expMultiplierDDT; //Field offset: 0xD8
	public float multiplierZOMG; //Field offset: 0xE0
	public string expMultiplierZOMG; //Field offset: 0xE8
	public bool onlyIfDamaged; //Field offset: 0xF0
	public string expOnlyIfDamaged; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 263
	}

	public PushBack() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

