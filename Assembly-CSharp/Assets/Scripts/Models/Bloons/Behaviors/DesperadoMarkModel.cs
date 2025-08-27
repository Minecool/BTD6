namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DesperadoMark), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DesperadoMarkModel : BloonBehaviorModelWithTowerTracking
{
	public float desperadoDamageMultiplier; //Field offset: 0x38
	public float popCashMultiplier; //Field offset: 0x3C

	public DesperadoMarkModel(string name, ObjectId tower, float desperadoDamageMultiplier, float popCashMultiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

