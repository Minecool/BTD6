namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MonkeyCity), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeyCityModel : TowerBehaviorModel
{
	public int roundsTillMultiplier; //Field offset: 0x30
	public string towerId; //Field offset: 0x38
	public float multiplier; //Field offset: 0x40
	public string mutatorId; //Field offset: 0x48

	public MonkeyCityModel(string name, int roundsTillMultiplier, string towerId, float multiplier, string mutatorId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

