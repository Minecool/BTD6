namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class BloodSacrifice : AbilityBehavior
{
	private static readonly String[] towerBanList; //Field offset: 0x0
	public BloodSacrificeModel bloodSacrificeModel; //Field offset: 0x68
	private ObjectId selectedTowerId; //Field offset: 0x70

	private static BloodSacrifice() { }

	public BloodSacrifice() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual bool CanUseAbility() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBanned(Tower tower) { }

	private void PlayActivateSound() { }

	private void PlayConfirmSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

