namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "DamageModifierForBloonType", menuName = "BTD6/Behaviors/Projectiles/DamageModifierForBloonType")]
public class DamageModifierForBloonType : DamageModifier
{
	public float multiplier; //Field offset: 0x30
	public float additive; //Field offset: 0x34
	public string includeChildTypes; //Field offset: 0x38
	[BloonType]
	public string bloonType; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public DamageModifierForBloonType() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

