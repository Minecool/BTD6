namespace Assets.Scripts.Simulation;

public class DialogueTriggerManager : RootBehavior
{

	public DialogueTriggerManager() { }

	public void DialoguePopupClosed() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Setup(bool isRestart) { }

	public void TriggerScripts(String[] triggers, int round = -1) { }

}

