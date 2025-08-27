namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AirUnit), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AirUnitModel : TowerBehaviorModel
{
	public TowerBehaviorModel[] behaviors; //Field offset: 0x30
	public PrefabReference display; //Field offset: 0x38
	public float displayScale; //Field offset: 0x40
	public bool isAirUnitSelectable; //Field offset: 0x44
	public float selectableRadius; //Field offset: 0x48
	public bool blocksPlacement; //Field offset: 0x4C
	public float blockingRadius; //Field offset: 0x50

	public AirUnitModel(string name, PrefabReference display, TowerBehaviorModel[] behaviors, float displayScale, bool isAirUnitSelectable, float selectableRadius, bool blocksPlacement, float blockingRadius) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

