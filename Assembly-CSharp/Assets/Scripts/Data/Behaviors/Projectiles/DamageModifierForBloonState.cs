namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamageModifierForBloonState", menuName = "BTD6/Behaviors/Projectiles/DamageModifierForBloonState")]
public class DamageModifierForBloonState : DamageModifier
{
	public float multiplier; //Field offset: 0x30
	public float additive; //Field offset: 0x34
	public string bloonStateValue; //Field offset: 0x38
	public bool mustIncludeAllTags; //Field offset: 0x40
	public bool applyOverMaxDamage; //Field offset: 0x41
	public bool mustBeModified; //Field offset: 0x42

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 195
	}

	public DamageModifierForBloonState() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

