namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(FighterPilotPatternLast), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FighterPilotPatternLastModel : TargetSupplierModel
{
	public bool isSelectable; //Field offset: 0x38
	public float offsetDistance; //Field offset: 0x3C

	public FighterPilotPatternLastModel(string name, bool isSelectable, float offsetDistance, bool isOnSubTower) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

