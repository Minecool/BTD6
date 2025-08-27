namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SupportRemoveFilterOutTag), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SupportRemoveFilterOutTagModel : SupportModel
{
	public string mutatorId; //Field offset: 0x60
	public string removeScriptWithSupportMutatorId; //Field offset: 0x68

	public SupportRemoveFilterOutTagModel(string name, string mutatorId, string removeScriptWithSupportMutatorId, TowerFilterModel[] filters, bool isGlobal, bool isCustomRadius, float customRadius, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

