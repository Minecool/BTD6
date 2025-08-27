namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ActivateAttackCreateTowerPlacement : AbilityBehavior
{
	public ActivateAttackCreateTowerPlacementModel behaviorModel; //Field offset: 0x68
	private bool isAttackActive; //Field offset: 0x70
	private List<RootBehavior> attacks; //Field offset: 0x78
	private WeaponCreateTower weaponCreateTowerBehavior; //Field offset: 0x80

	public ActivateAttackCreateTowerPlacement() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual void Attatched() { }

	public virtual bool CanTechBotActivate() { }

	public virtual bool CanUseAbility() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnDefeatScreen() { }

	protected virtual void OnDestroy() { }

	private void PauseAttack() { }

	private void UnpauseAttack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

