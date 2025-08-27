namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PyrotechnicsSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PyrotechnicsSupportModel : SupportModel
{
	public float percentIncrease; //Field offset: 0x60
	public bool isUnique; //Field offset: 0x64
	public string mutatorId; //Field offset: 0x68
	public int priority; //Field offset: 0x70

	public PyrotechnicsSupportModel(string name, float percentIncrease, bool isUnique, string mutatorId, int priority, TowerFilterModel[] filters, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

