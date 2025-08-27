namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RemoveMutatorWhenBehaviorDestroyed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveMutatorWhenBehaviorDestroyedModel : TowerBehaviorModel
{
	public string mutatorIds; //Field offset: 0x30
	public String[] mutatorIdsList; //Field offset: 0x38

	public RemoveMutatorWhenBehaviorDestroyedModel(string name, string mutatorIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

