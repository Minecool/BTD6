namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamageModifierForTag", menuName = "BTD6/Behaviors/Projectiles/DamageModifierForTag")]
public class DamageModifierForTag : DamageModifier
{
	public float additive; //Field offset: 0x30
	public string tagValue; //Field offset: 0x38
	public bool mustIncludeAllTags; //Field offset: 0x40
	public bool applyOverMaxDamage; //Field offset: 0x41

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 179
	}

	public DamageModifierForTag() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

