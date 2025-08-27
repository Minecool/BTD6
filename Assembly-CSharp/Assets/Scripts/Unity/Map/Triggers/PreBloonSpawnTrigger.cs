namespace Assets.Scripts.Unity.Map.Triggers;

public class PreBloonSpawnTrigger : MapTrigger
{
	public string bloonTag; //Field offset: 0x20
	private PreBloonSpawnTriggerModel def; //Field offset: 0x28

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 158
	}

	public PreBloonSpawnTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

