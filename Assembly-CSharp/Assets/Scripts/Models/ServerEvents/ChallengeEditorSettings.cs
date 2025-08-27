namespace Assets.Scripts.Models.ServerEvents;

public class ChallengeEditorSettings
{
	public bool isEnabled; //Field offset: 0x10
	public Restrictions restrictions; //Field offset: 0x18
	public RandomGenerator randomGenerator; //Field offset: 0x20

	public ChallengeEditorSettings() { }

}

