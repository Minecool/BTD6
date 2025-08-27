namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CentralMarketBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CentralMarketBuffModel : TowerBehaviorBuffModel
{
	public float multiplier; //Field offset: 0x48
	public string mutatorId; //Field offset: 0x50
	public int maxStackCount; //Field offset: 0x58

	public CentralMarketBuffModel(string name, float multiplier, string mutatorId, string buffLocsName, string buffIconName, int maxStackCount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

