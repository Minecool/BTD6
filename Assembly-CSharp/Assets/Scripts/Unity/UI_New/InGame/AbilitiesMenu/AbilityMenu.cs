namespace Assets.Scripts.Unity.UI_New.InGame.AbilitiesMenu;

public class AbilityMenu : RatioObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<AbilityToSimulation> <>9__25_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <RebuildAbilities>b__25_1(AbilityToSimulation a, AbilityToSimulation b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public SpriteReference sr; //Field offset: 0x10

		public <>c__DisplayClass43_0() { }

		internal bool <GetPooledAbilityButton>b__0(StackedAbilityButton b) { }

	}

	public static AbilityMenu instance; //Field offset: 0x0
	private const int animationStateShow = 0; //Field offset: 0x0
	private const int animationStateHide = 1; //Field offset: 0x0
	private const int sideNone = 0; //Field offset: 0x0
	private const int sideLeft = 1; //Field offset: 0x0
	private const int sideRight = 2; //Field offset: 0x0
	private readonly string visibleStateLabel; //Field offset: 0x20
	private readonly string SideLabel; //Field offset: 0x28
	public Animator panelAnimator; //Field offset: 0x30
	public Animator abilityGroupAnimator; //Field offset: 0x38
	public Animator buttonAnimator; //Field offset: 0x40
	public Animator rowAnimator; //Field offset: 0x48
	public Animator abilityShifterAnimator; //Field offset: 0x50
	public Transform row; //Field offset: 0x58
	public int abilitiesPerRow; //Field offset: 0x60
	public GameObject buttonPrefab; //Field offset: 0x68
	private List<StackedAbilityButton> pooledButtons; //Field offset: 0x70
	private List<StackedAbilityButton> activeButtons; //Field offset: 0x78
	private Dictionary<String, Int32> abilityOrderByName; //Field offset: 0x80
	private int abilityCount; //Field offset: 0x88
	private bool showingAbilities; //Field offset: 0x8C
	private bool showing; //Field offset: 0x8D
	private bool hideExternal; //Field offset: 0x8E
	private bool updateMenu; //Field offset: 0x8F

	public AbilityMenu() { }

	[CompilerGenerated]
	private int <RebuildAbilities>b__25_0(AbilityToSimulation a, AbilityToSimulation b) { }

	private void AbilitiesChanged() { }

	public void EndMatch() { }

	public List<StackedAbilityButton> GetAbilitiesButtons() { }

	private StackedAbilityButton GetPooledAbilityButton(SpriteReference sr) { }

	public void HideAbilities() { }

	private void HideAbilitiesPanel() { }

	public void HideShowExternal(bool hide) { }

	public virtual void Initialise() { }

	private void OnAbilitiesHighlightEvent(String[] abilityIds) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnRoundEnd(int round) { }

	public void OpenLeft(int abilityCount) { }

	public void OpenRight(int abilityCount) { }

	public int RebuildAbilities() { }

	public void ResetPanelPosition() { }

	private void ReturnAllAbilityButtons() { }

	private void ShowAbilities() { }

	private void ShowAbilitiesPanel() { }

	public void StartListeners() { }

	public void StartMatch() { }

	public void ToggleAbilities() { }

	private void TowerChanged(TowerToSimulation tow) { }

	public void Update() { }

	private void UpdateAbilityOrderMemoryForStandalone(List<AbilityToSimulation> abilities) { }

}

