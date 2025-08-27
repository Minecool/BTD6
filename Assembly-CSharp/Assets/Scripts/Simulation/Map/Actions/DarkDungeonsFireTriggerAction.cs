namespace Assets.Scripts.Simulation.Map.Actions;

public class DarkDungeonsFireTriggerAction : MapAction
{
	public DarkDungeonsFireTriggerActionModel triggerModel; //Field offset: 0x60

	public DarkDungeonsFireTriggerAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

