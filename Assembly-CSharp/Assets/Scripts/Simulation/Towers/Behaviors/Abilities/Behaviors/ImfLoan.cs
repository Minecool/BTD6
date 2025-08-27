namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ImfLoan : AbilityBehavior
{
	public ImfLoanModel imfLoanModel; //Field offset: 0x68

	public ImfLoan() { }

	public virtual void Activate() { }

	public void AddLoanCollectionBehavior(float amount) { }

	public virtual bool CanUseAbility() { }

	private bool HasImfLoanDebt() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	public virtual void OnPlace() { }

	private void OnTowerCreated(Tower tower, TowerModel towerModel, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerOwnerReassigned() { }

	public virtual bool ShowAbilityInBottomRow() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateStudentLoansAchievement() { }

}

