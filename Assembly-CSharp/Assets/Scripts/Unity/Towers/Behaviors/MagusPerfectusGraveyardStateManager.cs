namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MagusPerfectusGraveyardStateManager : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AttackManager, Attack> <>9__11_2; //Field offset: 0x8
		public static Func<GameObject, PrefabReference> <>9__11_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal PrefabReference <get_Def>b__11_0(GameObject x) { }

		internal Attack <get_Def>b__11_2(AttackManager x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string graveyardManaState; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <get_Def>b__1(AttackManager x) { }

	}

	public int maxManaStoredInGraveyard; //Field offset: 0x98
	public AttackManager[] attackManager; //Field offset: 0xA0
	public float rateBonusThreshold; //Field offset: 0xA8
	public float rateMultplierAmount; //Field offset: 0xAC
	public GameObject graveyardDisplay1; //Field offset: 0xB0
	public GameObject graveyardDisplay2; //Field offset: 0xB8
	public GameObject textDisplay; //Field offset: 0xC0
	public AudioClip switchAttackToGenerateSound; //Field offset: 0xC8
	public AudioClip switchAttackToConsumeSound; //Field offset: 0xD0
	public GameObject[] phoenixDisabledPrefabs; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1611
	}

	public MagusPerfectusGraveyardStateManager() { }

	[CompilerGenerated]
	private string <get_Def>b__11_3(Attack x) { }

	public virtual TowerBehaviorModel get_Def() { }

	private string GetAttackName(Attack attack) { }

}

