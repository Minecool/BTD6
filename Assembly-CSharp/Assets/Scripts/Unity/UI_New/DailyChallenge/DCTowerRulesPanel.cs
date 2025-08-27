namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCTowerRulesPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TowerData, Boolean> <>9__5_0; //Field offset: 0x8
		public static Func<TowerData, Boolean> <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <DisplayTowers>b__5_0(TowerData x) { }

		internal bool <DisplayTowers>b__5_1(TowerData x) { }

	}

	[SerializeField]
	private Transform towerContainer; //Field offset: 0x20
	[SerializeField]
	private GameObject towerPrefab; //Field offset: 0x28
	[SerializeField]
	private GameObject anyHeroPrefab; //Field offset: 0x30
	private readonly List<GameObject> towerDisplayList; //Field offset: 0x38

	public DCTowerRulesPanel() { }

	private void Awake() { }

	public void DisplayTowers(DailyChallengeModel dcm) { }

	private bool HasTowerCountsToShow(List<TowerData> towers) { }

}

