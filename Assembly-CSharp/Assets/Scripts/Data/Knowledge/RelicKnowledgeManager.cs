namespace Assets.Scripts.Data.Knowledge;

public static class RelicKnowledgeManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RelicKnowledgeItemBase, KnowledgeEffect> <>9__11_0; //Field offset: 0x8
		public static Func<KnowledgeEffect, Boolean> <>9__21_0; //Field offset: 0x10
		public static Func<MutatorModModel, Boolean> <>9__21_1; //Field offset: 0x18
		public static Func<MutatorModModel, Boolean> <>9__21_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyTowerDiscounts>b__21_0(KnowledgeEffect x) { }

		internal bool <ApplyTowerDiscounts>b__21_1(MutatorModModel x) { }

		internal bool <ApplyTowerDiscounts>b__21_2(MutatorModModel x) { }

		internal KnowledgeEffect <RefreshContestedTerritoryModifiers>b__11_0(RelicKnowledgeItemBase x) { }

	}

	private static readonly List<KnowledgeEffect> towerEffects; //Field offset: 0x0
	private static readonly List<KnowledgeEffect> bloonEffects; //Field offset: 0x8
	private static readonly List<KnowledgeEffect> powerEffects; //Field offset: 0x10
	private static readonly List<KnowledgeEffect> simulationEffects; //Field offset: 0x18
	private static readonly List<IModifyContestedTerritoryRules> activeRuleModifications; //Field offset: 0x20
	private static KnowledgeEffect startingCashEffect; //Field offset: 0x28
	[CompilerGenerated]
	private static List<ContestedTerritoryRelicType> <activeCtRelics>k__BackingField; //Field offset: 0x30

	public private static List<ContestedTerritoryRelicType> activeCtRelics
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public static KnowledgeEffect StartingCashEffect
	{
		 get { } //Length: 79
	}

	private static RelicKnowledgeManager() { }

	public static void AddActiveKnowledgeEffect(KnowledgeEffect effect) { }

	public static void ApplyBloonEffects(BloonModel bloon) { }

	public static void ApplyPowerEffects(PowerModel power) { }

	public static void ApplyRelicEffectsToDCM(ActiveRelicKnowledge activeRelicKnowledge, DailyChallengeModel dcm, bool removePowers = true) { }

	public static void ApplySimulationEffects(GameModel model, GameModel unmodded) { }

	private static void ApplyTowerDiscounts(IEnumerable<KnowledgeEffect> activeRelicKnowledge) { }

	public static void ApplyTowerEffects(TowerModel tower) { }

	public static void ClearDailyChallengeModelEffects(DailyChallengeModel dcm, bool removePowers = true) { }

	[CompilerGenerated]
	public static List<ContestedTerritoryRelicType> get_activeCtRelics() { }

	public static KnowledgeEffect get_StartingCashEffect() { }

	public static void RefreshContestedTerritoryModifiers(List<RelicKnowledgeItemBase> activeRelicKnowledge) { }

	public static void Reset() { }

	[CompilerGenerated]
	private static void set_activeCtRelics(List<ContestedTerritoryRelicType> value) { }

}

