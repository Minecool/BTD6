namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SlowModifierForTag : ProjectileBehavior
{
	public SlowModifierForTag parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	[FormerlySerializedAs("tag")]
	public string tagValue; //Field offset: 0xA0
	[FormerlySerializedAs("expTag")]
	public string expTagValue; //Field offset: 0xA8
	public bool makeNotTag; //Field offset: 0xB0
	public string expMakeNotTag; //Field offset: 0xB8
	public string slowId; //Field offset: 0xC0
	public string expSlowId; //Field offset: 0xC8
	public bool resetToUnmodified; //Field offset: 0xD0
	public string expResetToUnmodified; //Field offset: 0xD8
	public bool preventMutation; //Field offset: 0xE0
	public string expPreventMutation; //Field offset: 0xE8
	public float lifespanOverride; //Field offset: 0xF0
	public string expLifespanOverride; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 237
	}

	public SlowModifierForTag() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

