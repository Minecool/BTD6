namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RateSupportExplosive), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RateSupportExplosiveModel : SupportModel
{
	public float multiplier; //Field offset: 0x60
	public bool isUnique; //Field offset: 0x64
	public string mutatorId; //Field offset: 0x68

	public RateSupportExplosiveModel(string name, float multiplier, bool isUnique, string mutatorId, bool isGlobal, TowerFilterModel[] filters, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

