namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SelfStackingSupportCompounding), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SelfStackingSupportCompoundingModel : TowerBehaviorBuffModel
{
	public int maxStacks; //Field offset: 0x48
	public string mutatorId; //Field offset: 0x50
	public TowerFilterModel[] filters; //Field offset: 0x58

	public SelfStackingSupportCompoundingModel(string name, string mutatorId, int maxStacks, string buffLocsName, string buffIconName, TowerFilterModel[] filters, bool isGlobalRange = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

