namespace Assets.Scripts.Unity.Map.Triggers;

public class BloonsPoppedTrigger : MapTrigger
{
	public GameObject position; //Field offset: 0x20
	public int requiredBloons; //Field offset: 0x28
	public float radius; //Field offset: 0x2C
	public float cooldown; //Field offset: 0x30
	private BloonsPoppedTriggerModel def; //Field offset: 0x38

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 461
	}

	public BloonsPoppedTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

