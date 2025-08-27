namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SupportStackingRange), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SupportStackingRangeModel : SelfStackingSupportCompoundingModel
{
	public float rangeMultiplier; //Field offset: 0x60

	public SupportStackingRangeModel(string name, string mutatorId, int maxStacks, float rangeMultiplier, string buffLocsName, string buffIconName, TowerFilterModel[] filters, bool isGlobalRange) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

