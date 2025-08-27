namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SupportStackCounter), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SupportStackCounterModel : SelfStackingSupportCompoundingModel
{

	public SupportStackCounterModel(string name, string mutatorId, string buffLocsName, string buffIconName, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

