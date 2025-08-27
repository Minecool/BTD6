namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class FreezeModifierForTags : ProjectileBehavior
{
	public FreezeModifierForTags parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	public string tags; //Field offset: 0xA0
	public string expTags; //Field offset: 0xA8
	public string freezeId; //Field offset: 0xB0
	public string expFreezeId; //Field offset: 0xB8
	public bool resetToUnmodified; //Field offset: 0xC0
	public string expResetToUnmodified; //Field offset: 0xC8
	public bool preventMutation; //Field offset: 0xD0
	public string expPreventMutation; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 246
	}

	public FreezeModifierForTags() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

