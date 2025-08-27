namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

public abstract class TargetSupplierModel : AttackBehaviorModel
{
	public bool isOnSubTower; //Field offset: 0x30

	protected TargetSupplierModel(string name, bool isOnSubTower) { }

	public override bool ActionsOnCreate() { }

	public override bool ContinueToNextPriority() { }

	public abstract bool GetIsActionable() { }

	public abstract string GetName() { }

	public override string GetTargetTypeCustomInputClass() { }

	public abstract bool IsSelectable() { }

}

