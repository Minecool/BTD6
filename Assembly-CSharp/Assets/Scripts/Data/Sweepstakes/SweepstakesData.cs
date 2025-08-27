namespace Assets.Scripts.Data.Sweepstakes;

[CreateAssetMenu(menuName = "BTD6/Sweepstakes Data")]
public class SweepstakesData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__6_0; //Field offset: 0x8
		public static Func<String, Boolean> <>9__8_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetStepConditionIdNames>b__8_0(string name) { }

		internal bool <GetTaskIdNames>b__6_0(string name) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public string taskId; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <GetSweepstakesData>b__0(SweepstakesDataItem item) { }

	}

	internal class SweepstakesDataItem
	{
		public string taskId; //Field offset: 0x10
		[LocalizedText]
		public string taskNameLocsKey; //Field offset: 0x18
		public SpriteReference modeIcon; //Field offset: 0x20

		public SweepstakesDataItem() { }

	}

	internal class SweepstakesDetailsContainer
	{
		public SweepstakesDataItem[] items; //Field offset: 0x10

		public SweepstakesDetailsContainer() { }

	}

	internal enum SweepstakesStepConditionIds
	{
		None = 0,
		race_submission = 1,
		boss_submission = 2,
		any_map = 3,
		any_map_rounds = 4,
		any_beginner_map = 5,
		any_intermediate_map = 6,
		any_advanced_map = 7,
		any_expert_map = 8,
		easy_beginner_map = 9,
		easy_intermediate_map = 10,
		easy_advanced_map = 11,
		easy_expert_map = 12,
		medium_beginner_map = 13,
		medium_intermediate_map = 14,
		medium_advanced_map = 15,
		medium_expert_map = 16,
		hard_beginner_map = 17,
		hard_intermediate_map = 18,
		hard_advanced_map = 19,
		hard_expert_map = 20,
		easy_spec_map = 21,
		medium_spec_map = 22,
		hard_spec_map = 23,
		spec_rounds_map = 24,
		spec_hero = 25,
		different_heroes_or_skins = 26,
		capture_tile = 27,
	}

	internal enum SweepstakesTaskId
	{
		None = 0,
		pop_bloons = 1,
		game_events = 2,
		challenges = 3,
		boss_tiers = 4,
		beat_maps = 5,
		pop_moabs = 6,
		hero_wins = 7,
	}

	[ReorderableList("items", True)]
	[SerializeField]
	private SweepstakesDetailsContainer SweepstakesList; //Field offset: 0x18

	public SweepstakesData() { }

	private static bool ConditionHasGameDifficulty(string conditionId) { }

	private static bool ConditionHasMapDifficulty(string conditionId) { }

	private static string GetConditionGameDifficulty(string conditionId) { }

	private static string GetConditionMapDifficulty(string conditionId) { }

	public static string GetDescriptionForConditionIds(String[] conditionIds, int target) { }

	public static string GetDescriptionForTargetId(string targetId, int target) { }

	public static String[] GetStepConditionIdNames() { }

	public SweepstakesDataItem GetSweepstakesData(string taskId) { }

	public static String[] GetTaskIdNames() { }

	public static string TaskIdToLocsKey(SweepstakesTaskId taskId) { }

}

