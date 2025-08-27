namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class ManageShopPanel : EntityAction
{
	public ManageShopPanelModel behaviorModel; //Field offset: 0x68

	public ManageShopPanel() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

