namespace Assets.Scripts.Unity.Map.Triggers;

public class StartMapTrigger : MapTrigger
{
	private StartMapTriggerModel def; //Field offset: 0x20

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 141
	}

	public StartMapTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

