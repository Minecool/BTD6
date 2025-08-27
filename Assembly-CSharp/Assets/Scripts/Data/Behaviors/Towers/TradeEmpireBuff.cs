namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TradeEmpireBuff", menuName = "BTD6/Behaviors/Towers/TradeEmpireBuff")]
public class TradeEmpireBuff : TowerBehaviorGlobalBuff
{
	public float cashPerRoundPerMechantship; //Field offset: 0x40
	public float cashPerFavouredTrades; //Field offset: 0x44
	public int maxMerchantmanCapBonus; //Field offset: 0x48
	public int damageBuff; //Field offset: 0x4C
	public int ceramicDamageBuff; //Field offset: 0x50
	public int moabDamageBuff; //Field offset: 0x54
	public string mutatorId; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 257
	}

	public TradeEmpireBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

