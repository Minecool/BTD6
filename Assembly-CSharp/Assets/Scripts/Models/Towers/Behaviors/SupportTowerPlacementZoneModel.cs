namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SupportTowerPlacementZone), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SupportTowerPlacementZoneModel : SupportModel
{

	public SupportTowerPlacementZoneModel(string name, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

