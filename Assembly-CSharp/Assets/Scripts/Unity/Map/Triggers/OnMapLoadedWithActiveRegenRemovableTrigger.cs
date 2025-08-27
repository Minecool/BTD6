namespace Assets.Scripts.Unity.Map.Triggers;

public class OnMapLoadedWithActiveRegenRemovableTrigger : MapTrigger
{
	private OnMapLoadedWithActiveRegenRemovableTriggerModel def; //Field offset: 0x20
	public bool applyActionsWhenInactiveOnLoad; //Field offset: 0x28

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 158
	}

	public OnMapLoadedWithActiveRegenRemovableTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

