namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(TargetDesperado), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TargetDesperadoModel : TargetCamoModel
{
	public bool isSelectable; //Field offset: 0x38
	public bool canTargetMarked; //Field offset: 0x39
	public bool canPrioritiseCamo; //Field offset: 0x3A

	public TargetDesperadoModel(string name, bool isSelectable, bool isOnSubTower, bool canTargetMarked, bool canPrioritiseCamo) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

