namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(VisibilitySupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class VisibilitySupportModel : SupportModel
{
	public bool isUnique; //Field offset: 0x60
	public string mutatorId; //Field offset: 0x68

	public VisibilitySupportModel(string name, bool isUnique, string mutatorId, bool isGlobal, TowerFilterModel[] filters, string buffLocsName, string buffIconName, bool onlyAffectParagon = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

