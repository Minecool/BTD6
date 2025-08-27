namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities;

public abstract class AbilityBehavior : EntityBehavior, IAbilityBehavior, IEntityBehavior
{
	public Ability ability; //Field offset: 0x60

	protected AbilityBehavior() { }

	public override void Activate() { }

	public override void ApplyCustomInputData(CustomInputData data) { }

	public override bool CanTechBotActivate() { }

	public override bool CanUseAbility() { }

	public override SpriteReference GetAbilityIcon() { }

	public override string GetCustomInputClass(bool onAbilityActived = true) { }

	public override object GetCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsActive() { }

	public override void OnPlace() { }

	public override void PerformCustomUIAction() { }

	public override bool ShowAbilityInBottomRow() { }

	public override bool ShowInAbilityMenu() { }

}

