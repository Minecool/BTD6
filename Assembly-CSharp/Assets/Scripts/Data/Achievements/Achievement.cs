namespace Assets.Scripts.Data.Achievements;

public class Achievement : ScriptableObject
{
	public int achievementId; //Field offset: 0x18
	public SpriteReference achievementIcon; //Field offset: 0x20
	public SpriteReference hiddenAchievementIcon; //Field offset: 0x28
	public string subscript; //Field offset: 0x30
	public int achievementGoal; //Field offset: 0x38
	public string loot; //Field offset: 0x40
	public bool isCoop; //Field offset: 0x48
	public string steamStatName; //Field offset: 0x50
	public bool hidden; //Field offset: 0x58
	[TypeSelectionAsString("Assets.Scripts.Unity.Achievements.List", typeof(ActiveAchievement))]
	public string type; //Field offset: 0x60
	public string googlePlayId; //Field offset: 0x68

	public Achievement() { }

}

