namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TradeEmpireBuff : TowerBehaviorGlobalBuff
{
	public TradeEmpireBuff parent; //Field offset: 0xC8
	public float cashPerRoundPerMechantship; //Field offset: 0xD0
	public string expCashPerRoundPerMechantship; //Field offset: 0xD8
	public float cashPerFavouredTrades; //Field offset: 0xE0
	public string expCashPerFavouredTrades; //Field offset: 0xE8
	public int maxMerchantmanCapBonus; //Field offset: 0xF0
	public string expMaxMerchantmanCapBonus; //Field offset: 0xF8
	public int damageBuff; //Field offset: 0x100
	public string expDamageBuff; //Field offset: 0x108
	public int ceramicDamageBuff; //Field offset: 0x110
	public string expCeramicDamageBuff; //Field offset: 0x118
	public int moabDamageBuff; //Field offset: 0x120
	public string expMoabDamageBuff; //Field offset: 0x128
	public string mutatorId; //Field offset: 0x130
	public string expMutatorId; //Field offset: 0x138

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 287
	}

	public TradeEmpireBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

