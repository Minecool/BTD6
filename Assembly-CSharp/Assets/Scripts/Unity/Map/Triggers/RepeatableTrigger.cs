namespace Assets.Scripts.Unity.Map.Triggers;

public class RepeatableTrigger : MapTrigger
{
	private RepeatableTriggerModel def; //Field offset: 0x20
	public float repeatDelay; //Field offset: 0x28
	public RegenRemovable triggeredBy; //Field offset: 0x30

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 196
	}

	public RepeatableTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

