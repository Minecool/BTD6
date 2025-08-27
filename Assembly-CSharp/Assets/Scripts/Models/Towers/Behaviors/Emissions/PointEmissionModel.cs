namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(PointEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PointEmissionModel : EmissionModel
{
	public bool checkLineOfSight; //Field offset: 0x38

	public PointEmissionModel(string name, bool checkLineOfSight, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

