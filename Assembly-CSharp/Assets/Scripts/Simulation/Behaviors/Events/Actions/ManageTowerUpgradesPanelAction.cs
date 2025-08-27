namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class ManageTowerUpgradesPanelAction : EntityAction
{
	public ManageTowerUpgradesPanelActionModel behaviorModel; //Field offset: 0x68

	public ManageTowerUpgradesPanelAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

