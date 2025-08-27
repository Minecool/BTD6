namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "LongArmOfLight", menuName = "BTD6/Behaviors/Abilities/LongArmOfLight")]
public class LongArmOfLight : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public AssetPath projectileDisplay; //Field offset: 0x38
	public float projectileRadiusMultiplier; //Field offset: 0x40
	public string damageType; //Field offset: 0x48
	public int damageIncrease; //Field offset: 0x50
	public string mutatorId; //Field offset: 0x58

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 337
	}

	public LongArmOfLight() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

