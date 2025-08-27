namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CashPerBananaFarmInRange", menuName = "BTD6/Behaviors/Abilities/CashPerBananaFarmInRange")]
public class CashPerBananaFarmInRange : AbilityBehavior
{
	public float baseCash; //Field offset: 0x30
	public float cash; //Field offset: 0x34
	public float rangeIncrease; //Field offset: 0x38
	public PrefabReference textDisplay; //Field offset: 0x40
	public float textLifespan; //Field offset: 0x48
	public float lifespan; //Field offset: 0x4C

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 205
	}

	public CashPerBananaFarmInRange() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

