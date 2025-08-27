namespace Assets.Scripts.Unity.Map.Triggers;

public class OnMapCreatedTrigger : MapTrigger
{
	private OnMapCreatedTriggerModel def; //Field offset: 0x20

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 140
	}

	public OnMapCreatedTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

