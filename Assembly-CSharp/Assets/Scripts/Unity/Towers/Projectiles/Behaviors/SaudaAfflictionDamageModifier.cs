namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SaudaAfflictionDamageModifier : ProjectileBehavior
{
	public SaudaAfflictionDamageModifier parent; //Field offset: 0x88
	public string lv7Tags; //Field offset: 0x90
	public string expLv7Tags; //Field offset: 0x98
	public float lv7NonMoabBonus; //Field offset: 0xA0
	public string expLv7NonMoabBonus; //Field offset: 0xA8
	public float lv7MoabBonus; //Field offset: 0xB0
	public string expLv7MoabBonus; //Field offset: 0xB8
	public string lv11ExcludeTags; //Field offset: 0xC0
	public string expLv11ExcludeTags; //Field offset: 0xC8
	public float lv11NonMoabBonus; //Field offset: 0xD0
	public string expLv11NonMoabBonus; //Field offset: 0xD8
	public float lv11MoabBonus; //Field offset: 0xE0
	public string expLv11MoabBonus; //Field offset: 0xE8
	public string lv19BloonTags; //Field offset: 0xF0
	public string expLv19BloonTags; //Field offset: 0xF8
	public float lv19NonMoabBonus; //Field offset: 0x100
	public string expLv19NonMoabBonus; //Field offset: 0x108
	public float lv19MoabBonus; //Field offset: 0x110
	public string expLv19MoabBonus; //Field offset: 0x118

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 403
	}

	public SaudaAfflictionDamageModifier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

