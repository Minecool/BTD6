namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CashBoost", menuName = "BTD6/Behaviors/Abilities/CashBoost")]
public class CashBoost : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public float range; //Field offset: 0x38
	public string filterTower; //Field offset: 0x40

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 185
	}

	public CashBoost() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

