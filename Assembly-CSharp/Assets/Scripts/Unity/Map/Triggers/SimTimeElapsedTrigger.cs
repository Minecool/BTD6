namespace Assets.Scripts.Unity.Map.Triggers;

public class SimTimeElapsedTrigger : MapTrigger
{
	public float time; //Field offset: 0x20
	public int rounds; //Field offset: 0x24
	public bool useRoundTime; //Field offset: 0x28
	private SimTimeElapsedTriggerModel def; //Field offset: 0x30

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 220
	}

	public SimTimeElapsedTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

