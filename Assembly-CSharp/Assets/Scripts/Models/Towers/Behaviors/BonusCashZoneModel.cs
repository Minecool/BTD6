namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BonusCashZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BonusCashZoneModel : TowerBehaviorModel
{
	public float multiplier; //Field offset: 0x30
	public string stackName; //Field offset: 0x38
	public string groupName; //Field offset: 0x40
	public int stackLimit; //Field offset: 0x48

	public BonusCashZoneModel(string name, float multiplier, string stackName, string groupName, int stackLimit) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

