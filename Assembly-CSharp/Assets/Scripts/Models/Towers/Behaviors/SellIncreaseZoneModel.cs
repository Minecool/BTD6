namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SellIncreaseZone), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SellIncreaseZoneModel : TowerBehaviorModel
{
	public TowerFilterModel[] filters; //Field offset: 0x30
	public float sellMultiplier; //Field offset: 0x38
	public string stackName; //Field offset: 0x40

	public SellIncreaseZoneModel(string name, float sellMultiplier, string stackName, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

