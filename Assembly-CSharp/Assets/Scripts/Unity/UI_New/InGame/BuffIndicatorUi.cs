namespace Assets.Scripts.Unity.UI_New.InGame;

public class BuffIndicatorUi : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BuffIconSprite, Boolean> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Awake>b__10_0(BuffIconSprite x) { }

	}

	public static BuffIndicatorUi instance; //Field offset: 0x0
	public GameObject buffsUi; //Field offset: 0x20
	public GameObject buffPrefab; //Field offset: 0x28
	private Dictionary<String, BuffIcon> allBuffIcons; //Field offset: 0x30
	private List<TowerToSimulation> towers; //Field offset: 0x38
	private List<TowerToSimulation> towersInRangeOfPlaceableTower; //Field offset: 0x40
	private List<TowerToSimulation> towersToHighlightForPlaceableTower; //Field offset: 0x48
	private List<TowerToSimulation> towersBuffingThisTower; //Field offset: 0x50
	private readonly float upperBoundary; //Field offset: 0x58
	private readonly float sideBoundary; //Field offset: 0x5C
	private Dictionary<String, BuffQuery> stackedBuffs; //Field offset: 0x60

	public BuffIndicatorUi() { }

	public void Awake() { }

	public void ClearBuffHighlightUI() { }

	private Dictionary<String, BuffQuery> FindTowersThatWillBuffPlacementTower(PlacementQuery placementQuery, TowerModel placementTowerModel) { }

	private bool GetShouldHighlightAllTowersInRange(TowerModel placementTowerModel) { }

	public Dictionary<String, BuffQuery> GroupStackableBuffs(IEnumerable<BuffQuery> buffs) { }

	private BuffQuery HandleStackingCapability(BuffQuery data, BuffQuery buff) { }

	public void Hide() { }

	private void OnDestroy() { }

	public void PreShow() { }

	private Vector2 ShiftPositionOnBoundaries(float x, float y) { }

	public void Show(Vector2 towerPosition, PlacementQuery placementQuery, TowerModel placementTowerModel) { }

	public void UpdatePlacedTowerBuffs(TowerToSimulation tower) { }

}

