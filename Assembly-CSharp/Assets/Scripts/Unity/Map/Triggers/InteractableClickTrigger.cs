namespace Assets.Scripts.Unity.Map.Triggers;

public class InteractableClickTrigger : MapTrigger
{
	public InteractableClick interactableClick; //Field offset: 0x20
	public float cooldownDuration; //Field offset: 0x28
	private InteractableClickTriggerModel def; //Field offset: 0x30

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 232
	}

	public InteractableClickTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

