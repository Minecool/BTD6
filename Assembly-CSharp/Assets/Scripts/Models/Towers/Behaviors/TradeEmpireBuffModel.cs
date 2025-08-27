namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TradeEmpireBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TradeEmpireBuffModel : TowerBehaviorBuffModel
{
	public float cashPerRoundPerMechantship; //Field offset: 0x48
	public float cashPerRoundPerFavouredTrades; //Field offset: 0x4C
	public int maxMerchantmanCapBonus; //Field offset: 0x50
	public int damageBuff; //Field offset: 0x54
	public int ceramicDamageBuff; //Field offset: 0x58
	public int moabDamageBuff; //Field offset: 0x5C
	public string mutatorId; //Field offset: 0x60

	public TradeEmpireBuffModel(string name, float cashPerRoundPerMechantship, float cashPerRoundPerFavouredTrades, int maxMerchantmanCapBonus, string buffLocsName, string buffIconName, bool isGlobalRange, int damageBuff, int ceramicDamageBuff, int moabDamageBuff, string mutatorId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

