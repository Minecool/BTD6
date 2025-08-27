namespace Assets.Scripts.Unity.Map.Triggers;

public class InteractableClickSequenceTrigger : MapTrigger
{
	public InteractableClickSequence interactableClickSequence; //Field offset: 0x20
	private InteractableClickSequenceTriggerModel def; //Field offset: 0x28

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 192
	}

	public InteractableClickSequenceTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

