namespace Assets.Scripts.Data.Knowledge;

public static class KnowledgeHelper
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KnowledgeModel, Int32> <>9__8_0; //Field offset: 0x8
		public static Func<Int32, Int32> <>9__8_1; //Field offset: 0x10
		public static Func<KnowledgeModel, Int32> <>9__9_0; //Field offset: 0x18
		public static Func<Int32, Int32> <>9__9_1; //Field offset: 0x20
		public static Func<KnowledgeModel, IEnumerable`1<MutatorModModel>> <>9__14_1; //Field offset: 0x28
		public static Func<String, Boolean> <>9__15_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal int <GetCategoryDistinctCosts>b__9_0(KnowledgeModel x) { }

		internal int <GetCategoryDistinctCosts>b__9_1(int x) { }

		internal int <GetCategoryDistinctRequiredInvestments>b__8_0(KnowledgeModel x) { }

		internal int <GetCategoryDistinctRequiredInvestments>b__8_1(int x) { }

		internal bool <KnowledgeHasAllPrerequisites>b__15_0(string x) { }

		internal IEnumerable<MutatorModModel> <OnMonkeyKnowledgePurchase>b__14_1(KnowledgeModel k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string knowledgeName; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <OnMonkeyKnowledgePurchase>b__0(KnowledgeModel k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string knowledgeId; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <GetKnowledge>b__0(KnowledgeModel x) { }

	}

	public static readonly KnowledgeCategory[] AllKnowlegeCategories; //Field offset: 0x0

	private static KnowledgeHelper() { }

	public static Int32[] GetCategoryDistinctCosts(KnowledgeCategory category) { }

	public static Int32[] GetCategoryDistinctRequiredInvestments(KnowledgeCategory category) { }

	public static int GetCategoryLearntTotal(KnowledgeCategory category) { }

	public static string GetCategoryProgressString(KnowledgeCategory category) { }

	public static int GetCategoryTotal(KnowledgeCategory category) { }

	public static KnowledgeModel GetKnowledge(string knowledgeId) { }

	public static bool GetKnowledgeCategory(string knowledgeId, out KnowledgeCategory category) { }

	public static string GetKnowledgeCategoryName(string knowledgeId) { }

	public static KnowledgeModel[] GetKnowledgeForCategory(KnowledgeCategory category) { }

	public static int GetMonkeyMoneyCost(string knowledgeId) { }

	public static int GetTierInvestmentRequirement(string knowledgeId) { }

	public static bool IsKnowledgePurchasable(string knowledgeId) { }

	public static KnowledgePurchaseRequirement IsKnowledgePurchasableReason(string knowledgeId, ref List<String>& prereqIDs, ref int setLearntTotal) { }

	private static bool KnowledgeHasAllPrerequisites(KnowledgeModel knowledgeModel) { }

	private static bool KnowledgeHasRequiredInvestment(KnowledgeModel knowledgeModel) { }

	public static void OnMonkeyKnowledgePurchase(string knowledgeName) { }

}

