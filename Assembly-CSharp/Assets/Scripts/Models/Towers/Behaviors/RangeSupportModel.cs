namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RangeSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RangeSupportModel : SupportModel
{
	public float multiplier; //Field offset: 0x60
	public float additive; //Field offset: 0x64
	public string mutatorId; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70

	public RangeSupportModel(string name, bool isUnique, float multiplier, float additive, string mutatorId, TowerFilterModel[] filters, bool isGlobal, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

