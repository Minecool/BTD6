namespace Assets.Scripts.Data.Achievements;

public class AchievementData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetAchievement>b__0(Achievement element) { }

	}

	[SerializeField]
	private List<Achievement> achievements; //Field offset: 0x18

	public IEnumerable<Achievement> Achievements
	{
		 get { } //Length: 5
	}

	public AchievementData() { }

	public IEnumerable<Achievement> get_Achievements() { }

	public Achievement GetAchievement(int id) { }

}

