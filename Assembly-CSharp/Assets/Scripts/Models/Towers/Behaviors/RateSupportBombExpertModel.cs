namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RateSupportBombExpert), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RateSupportBombExpertModel : SupportModel
{
	public float rangeMultiplier; //Field offset: 0x60
	public float pierceMultiplier; //Field offset: 0x64
	public bool isUnique; //Field offset: 0x68

	public RateSupportBombExpertModel(string name, bool isUnique, bool isGlobal, float rangeMultiplier, float pierceMultiplier, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

