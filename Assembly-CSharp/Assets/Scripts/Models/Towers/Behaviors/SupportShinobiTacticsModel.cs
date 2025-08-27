namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SupportShinobiTactics), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SupportShinobiTacticsModel : SelfStackingSupportCompoundingModel
{
	public float multiplier; //Field offset: 0x60

	public SupportShinobiTacticsModel(string name, string mutatorId, int maxStacks, float multiplier, string buffLocsName, string buffIconName, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

