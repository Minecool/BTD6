namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DamageOverTimeDurationSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageOverTimeDurationSupportModel : SupportModel
{
	public float durationMultiplier; //Field offset: 0x60
	public string mutatorId; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70

	public DamageOverTimeDurationSupportModel(string name, bool isUnique, float durationMultiplier, string mutatorId, TowerFilterModel[] filters, bool isGlobal, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

