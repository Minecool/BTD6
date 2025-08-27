namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CashIncrease", menuName = "BTD6/Behaviors/Towers/CashIncrease")]
public class CashIncrease : TowerBehavior
{
	public float increase; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public CashIncrease() { }

	public virtual TowerBehaviorModel get_Def() { }

}

