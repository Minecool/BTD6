namespace Assets.Scripts.Unity.Map.Triggers;

public class LivesLowerThanTrigger : MapTrigger
{
	public int lives; //Field offset: 0x20
	public bool usePercent; //Field offset: 0x24
	public float percent; //Field offset: 0x28
	private LivesLowerThanTriggerModel def; //Field offset: 0x30

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 223
	}

	public LivesLowerThanTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

