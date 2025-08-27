namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "DamageUp", menuName = "BTD6/Behaviors/Abilities/DamageUp")]
public class DamageUp : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public int additionalDamage; //Field offset: 0x34
	public AssetPathModel projectileDisplay; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 157
	}

	public DamageUp() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

