namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PiercePercentageSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PiercePercentageSupportModel : SupportModel
{
	public float percentIncrease; //Field offset: 0x60
	public string mutatorId; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70
	public int priority; //Field offset: 0x74

	public PiercePercentageSupportModel(string name, bool isUnique, float percentIncrease, string mutatorId, TowerFilterModel[] filters, bool isGlobal, string buffLocsName, string buffIconName, int priority) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

