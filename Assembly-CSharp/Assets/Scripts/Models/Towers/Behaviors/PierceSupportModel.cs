namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PierceSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PierceSupportModel : SupportModel
{
	public float pierce; //Field offset: 0x60
	public string mutatorId; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70

	public PierceSupportModel(string name, bool isUnique, float pierce, string mutatorId, TowerFilterModel[] filters, bool isGlobal, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

