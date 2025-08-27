namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(AttackFilter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AttackFilterModel : AttackBehaviorModel
{
	public FilterModel[] filters; //Field offset: 0x30

	public AttackFilterModel(string name, FilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

