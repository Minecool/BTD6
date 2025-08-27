namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BananaBonusCashZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BananaBonusCashZoneModel : TowerBehaviorModel
{
	public float multiplier; //Field offset: 0x30

	public BananaBonusCashZoneModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

