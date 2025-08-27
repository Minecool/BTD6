namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamageModifierWrath", menuName = "BTD6/Behaviors/Projectiles/DamageModifierWrath")]
public class DamageModifierWrath : DamageModifier
{
	public int rbeThreshold; //Field offset: 0x30
	public int damage; //Field offset: 0x34
	public int maxDamageBoost; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 145
	}

	public DamageModifierWrath() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

