namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetDesperadoStrong), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetDesperadoStrongModel : TargetDesperadoModel
{

	public TargetDesperadoStrongModel(string name, bool isSelectable, bool isOnSubTower, bool canTargetMarked, bool canPrioritiseCamo) { }

	public virtual Model Clone() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

