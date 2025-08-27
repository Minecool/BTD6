namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageModifierForBloonState : DamageModifier
{
	public DamageModifierForBloonState parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	public float additive; //Field offset: 0xA0
	public string expAdditive; //Field offset: 0xA8
	[FormerlySerializedAs("tag")]
	public string bloonStateValue; //Field offset: 0xB0
	[FormerlySerializedAs("expBloonState")]
	public string expBloonStateValue; //Field offset: 0xB8
	public bool mustIncludeAllTags; //Field offset: 0xC0
	public string expMustIncludeAllTags; //Field offset: 0xC8
	public bool applyOverMaxDamage; //Field offset: 0xD0
	public string expApplyOverMaxDamage; //Field offset: 0xD8
	public bool mustBeModified; //Field offset: 0xE0
	public string expMustBeModified; //Field offset: 0xE8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 234
	}

	public DamageModifierForBloonState() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

