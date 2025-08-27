namespace Assets.Scripts.Simulation.Map.Actions;

public class ChangeSimTimeElapsedTriggerAction : MapAction
{
	public ChangeSimTimeElapsedTriggerActionModel changeSimTimeElapsedTriggerActionModel; //Field offset: 0x60

	public ChangeSimTimeElapsedTriggerAction() { }

	public virtual void GotoPostAction(int triggerCount, bool loadSave) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

