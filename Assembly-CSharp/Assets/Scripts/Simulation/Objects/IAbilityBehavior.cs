namespace Assets.Scripts.Simulation.Objects;

public interface IAbilityBehavior : IEntityBehavior
{

	public void Activate() { }

	public void ApplyCustomInputData(CustomInputData data) { }

	public bool CanTechBotActivate() { }

	public bool CanUseAbility() { }

	public SpriteReference GetAbilityIcon() { }

	public string GetCustomInputClass(bool onAbilityActived = true) { }

	public object GetCustomInputData() { }

	public bool IsActive() { }

	public void OnPlace() { }

	public void PerformCustomUIAction() { }

	public bool ShowAbilityInBottomRow() { }

	public bool ShowInAbilityMenu() { }

}

