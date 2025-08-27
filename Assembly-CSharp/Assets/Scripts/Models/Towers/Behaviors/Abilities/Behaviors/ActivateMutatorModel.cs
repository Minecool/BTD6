namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateMutatorModel : AbilityBehaviorModel
{
	public TowerMutatorModel towerMutatorModel; //Field offset: 0x30

	public ActivateMutatorModel(string name, TowerMutatorModel towerMutatorModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

