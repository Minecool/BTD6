namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MonkeySubParagonSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeySubParagonSupportModel : SupportModel
{
	public float subBonusDamageMultiplier; //Field offset: 0x60
	public float subBonusPierceMultiplier; //Field offset: 0x64
	public float heroBonusDamageMultiplier; //Field offset: 0x68
	public float heroBonusPierceMultiplier; //Field offset: 0x6C
	public float heroRateMultiplier; //Field offset: 0x70
	public float heroXpMultiplier; //Field offset: 0x74

	public MonkeySubParagonSupportModel(string name, float subBonusDamageMultiplier, float subBonusPierceMultiplier, float heroBonusDamageMultiplier, float heroBonusPierceMultiplier, float heroRateMultiplier, float heroXpMultiplier, TowerFilterModel[] filters, string buffLocsName, string buffIconName, bool isGlobal) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

