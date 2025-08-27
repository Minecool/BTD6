namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerMutatorGroup), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerMutatorGroupModel : TowerBehaviorModel
{
	public TowerMutatorModel[] mutators; //Field offset: 0x30

	public TowerMutatorGroupModel(string name, TowerMutatorModel[] mutators) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

