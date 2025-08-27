namespace Assets.Scripts.Models.Profile;

public class InGameSettings
{
	public bool doubleCash; //Field offset: 0x10
	public bool autoPlay; //Field offset: 0x11
	public bool lineOfSight; //Field offset: 0x12
	public bool dropAndLock; //Field offset: 0x13
	public bool gameHints; //Field offset: 0x14
	public bool queueRogueBoosts; //Field offset: 0x15

	public InGameSettings() { }

}

