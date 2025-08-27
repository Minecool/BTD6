namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageModifierForTag : DamageModifier
{
	public DamageModifierForTag parent; //Field offset: 0x88
	public float additive; //Field offset: 0x90
	public string expAdditive; //Field offset: 0x98
	[FormerlySerializedAs("tag")]
	public string tagValue; //Field offset: 0xA0
	[FormerlySerializedAs("expTag")]
	public string expTagValue; //Field offset: 0xA8
	public bool mustIncludeAllTags; //Field offset: 0xB0
	public string expMustIncludeAllTags; //Field offset: 0xB8
	public bool applyOverMaxDamage; //Field offset: 0xC0
	public string expApplyOverMaxDamage; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 223
	}

	public DamageModifierForTag() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

