namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(IgnoreAllMutatorsTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IgnoreAllMutatorsTowerModel : TowerBehaviorModel
{

	public IgnoreAllMutatorsTowerModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

