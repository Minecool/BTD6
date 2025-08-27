namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamageModifierForModifiers", menuName = "BTD6/Behaviors/Projectiles/DamageModifierForModifiers")]
public class DamageModifierForModifiers : DamageModifier
{
	public float multiplier; //Field offset: 0x30
	public float additive; //Field offset: 0x34
	public string modifiers; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public DamageModifierForModifiers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

