namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(OverrideCamoDetection), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OverrideCamoDetectionModel : TowerBehaviorModel
{
	public bool detectCamo; //Field offset: 0x30

	public OverrideCamoDetectionModel(string name, bool detectCamo) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

