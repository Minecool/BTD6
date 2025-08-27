namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class RemoveBloonModifiers : ProjectileBehavior
{
	public RemoveBloonModifiers parent; //Field offset: 0x88
	public bool cleanseRegen; //Field offset: 0x90
	public string expCleanseRegen; //Field offset: 0x98
	public bool cleanseCamo; //Field offset: 0xA0
	public string expCleanseCamo; //Field offset: 0xA8
	public bool cleanseLead; //Field offset: 0xB0
	public string expCleanseLead; //Field offset: 0xB8
	public bool cleanseFortified; //Field offset: 0xC0
	public string expCleanseFortified; //Field offset: 0xC8
	public bool cleanseOnlyIfDamaged; //Field offset: 0xD0
	public string expCleanseOnlyIfDamaged; //Field offset: 0xD8
	public string bloonTagExclude; //Field offset: 0xE0
	public string expBloonTagExclude; //Field offset: 0xE8
	public string bloonTagExplicit; //Field offset: 0xF0
	public string expBloonTagExplicit; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 303
	}

	public RemoveBloonModifiers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

