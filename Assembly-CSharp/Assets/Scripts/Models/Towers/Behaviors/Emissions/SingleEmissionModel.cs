namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(SingleEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SingleEmissionModel : EmissionModel
{

	public SingleEmissionModel(string name, EmissionBehaviorModel[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

