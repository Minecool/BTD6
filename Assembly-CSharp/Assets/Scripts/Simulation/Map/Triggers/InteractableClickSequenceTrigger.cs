namespace Assets.Scripts.Simulation.Map.Triggers;

public class InteractableClickSequenceTrigger : MapTrigger
{
	private InteractableClickSequenceTriggerModel icsModel; //Field offset: 0x80

	public InteractableClickSequenceTrigger() { }

	public virtual void DeInit() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void SeqComplete(string interactableClickSequenceName) { }

}

