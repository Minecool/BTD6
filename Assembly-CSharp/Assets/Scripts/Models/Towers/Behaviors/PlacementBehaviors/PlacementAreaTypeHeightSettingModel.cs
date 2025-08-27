namespace Assets.Scripts.Models.Towers.Behaviors.PlacementBehaviors;

[Implementation(typeof(PlacementAreaTypeHeightSetting), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PlacementAreaTypeHeightSettingModel : PlacementBehaviorModel
{
	public float landHeight; //Field offset: 0x30
	public float waterHeight; //Field offset: 0x34

	public PlacementAreaTypeHeightSettingModel(string name, float landHeight, float waterHeight) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual Vector3 SetPlacerTransform(Vector3 placerTransform, Area[] areas) { }

}

