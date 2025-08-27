namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MagusPerfectusGraveyardStateManager", menuName = "BTD6/Behaviors/Towers/MagusPerfectusGraveyardStateManager")]
public class MagusPerfectusGraveyardStateManager : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AttackManager, Attack> <>9__11_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Attack <get_Def>b__11_1(AttackManager x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string graveyardManaState; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <get_Def>b__0(AttackManager x) { }

	}

	public int maxManaStoredInGraveyard; //Field offset: 0x30
	public AttackManager[] attackManager; //Field offset: 0x38
	public float rateBonusThreshold; //Field offset: 0x40
	public float rateMultplierAmount; //Field offset: 0x44
	public PrefabReference graveyardDisplay1; //Field offset: 0x48
	public PrefabReference graveyardDisplay2; //Field offset: 0x50
	public PrefabReference textDisplay; //Field offset: 0x58
	public Sound switchAttackToGenerateSound; //Field offset: 0x60
	public Sound switchAttackToConsumeSound; //Field offset: 0x68
	public PrefabReference[] phoenixDisabledPrefabs; //Field offset: 0x70

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1040
	}

	public MagusPerfectusGraveyardStateManager() { }

	[CompilerGenerated]
	private string <get_Def>b__11_2(Attack x) { }

	public virtual TowerBehaviorModel get_Def() { }

	private string GetAttackName(Attack attack) { }

}

