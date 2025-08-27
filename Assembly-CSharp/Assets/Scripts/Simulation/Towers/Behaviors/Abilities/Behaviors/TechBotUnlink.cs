namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class TechBotUnlink : AbilityBehavior
{
	public TechBotUnlinkModel techBotUnlinkModel; //Field offset: 0x68
	private TechBotLink techBotLink; //Field offset: 0x70

	public TechBotUnlink() { }

	public virtual void Activate() { }

	private TechBotLink GetTechBotLink() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual bool ShowAbilityInBottomRow() { }

	public virtual bool ShowInAbilityMenu() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

