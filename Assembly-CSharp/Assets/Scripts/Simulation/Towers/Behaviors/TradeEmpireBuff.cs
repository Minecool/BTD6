namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TradeEmpireBuff : TowerBehaviorBuff
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TradeEmpireBuff, Boolean> <>9__8_0; //Field offset: 0x8
		public static Func<MerchantShip, Boolean> <>9__8_1; //Field offset: 0x10
		public static Func<MerchantShip, Boolean> <>9__8_2; //Field offset: 0x18
		public static Func<MerchantShip, Boolean> <>9__9_0; //Field offset: 0x20
		public static Func<MerchantShip, Int32> <>9__9_1; //Field offset: 0x28
		public static Func<MerchantShip, Boolean> <>9__9_2; //Field offset: 0x30
		public static Func<MerchantShip, Boolean> <>9__9_3; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <Process>b__8_0(TradeEmpireBuff behavior) { }

		internal bool <Process>b__8_1(MerchantShip behavior) { }

		internal bool <Process>b__8_2(MerchantShip behavior) { }

		internal bool <UpdateMutators>b__9_0(MerchantShip x) { }

		internal int <UpdateMutators>b__9_1(MerchantShip behavior) { }

		internal bool <UpdateMutators>b__9_2(MerchantShip behavior) { }

		internal bool <UpdateMutators>b__9_3(MerchantShip behavior) { }

	}

	public TradeEmpireBuffModel tradeEmpireBuffModel; //Field offset: 0x70
	private int lastNumberOfTradeEmpires; //Field offset: 0x78
	private int lastNumberOfMerchantShips; //Field offset: 0x7C
	private int lastNumberFavouredTrades; //Field offset: 0x80

	public TradeEmpireBuff() { }

	private int GetMatchingTradeEmpireCount() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UpdateMutators() { }

}

