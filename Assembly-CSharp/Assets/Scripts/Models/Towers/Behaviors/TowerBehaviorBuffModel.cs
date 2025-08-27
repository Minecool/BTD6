namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerBehaviorBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerBehaviorBuffModel : TowerBehaviorModel
{
	public string buffLocsName; //Field offset: 0x30
	public string buffIconName; //Field offset: 0x38
	public int maxStackSize; //Field offset: 0x40
	public bool isGlobalRange; //Field offset: 0x44

	public TowerBehaviorBuffModel(string id, string buffLocsName, string buffIconName, bool isGlobalRange = false, int maxStackSize = 0) { }

	public virtual Model Clone() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

