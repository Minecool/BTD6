namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities;

public class Ability : TowerBehavior
{
	private const float startCooldownFraction = 0.33; //Field offset: 0x0
	public AbilityModel abilityModel; //Field offset: 0x68
	private List<RootBehavior> createdBehaviors; //Field offset: 0x70
	private float cooldownTimeRemaining; //Field offset: 0x78
	public int frameAdded; //Field offset: 0x7C
	private int previousTier; //Field offset: 0x80
	public float animationStartedAt; //Field offset: 0x84
	public float lastActivatedAt; //Field offset: 0x88
	public int activationsThisRound; //Field offset: 0x8C
	private bool abilityUpdated; //Field offset: 0x90
	public int currentAdditionalCharges; //Field offset: 0x94
	private TSMInfoModel tsmInfoModel; //Field offset: 0x98
	public bool hideAbility; //Field offset: 0xA0
	public bool hideAbilityInBottomRow; //Field offset: 0xA1

	public float CooldownRemaining
	{
		 get { } //Length: 42
		 set { } //Length: 55
	}

	public int FrameAdded
	{
		 get { } //Length: 4
	}

	public bool IsAbilityMaxRoundTimerReached
	{
		 get { } //Length: 81
	}

	public bool IsActive
	{
		 get { } //Length: 354
	}

	public bool IsEnabled
	{
		 get { } //Length: 64
	}

	public bool ShowAbilityInBottomRow
	{
		 get { } //Length: 396
	}

	public bool ShowInAbilityMenu
	{
		 get { } //Length: 460
	}

	public Ability() { }

	public void Activate(bool ignoreCooldown = false) { }

	public void ApplyCustomInputData(CustomInputData data) { }

	public bool CanTechBotActivate() { }

	public bool CanUseAbility() { }

	public bool ClearCooldown() { }

	public float get_CooldownRemaining() { }

	public int get_FrameAdded() { }

	public bool get_IsAbilityMaxRoundTimerReached() { }

	public bool get_IsActive() { }

	public bool get_IsEnabled() { }

	public bool get_ShowAbilityInBottomRow() { }

	public bool get_ShowInAbilityMenu() { }

	public string GetCustomInputClass(bool onAbilityActived = true) { }

	public object GetCustomInputData() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsCashGenerating() { }

	public bool IsReady(bool ignoreCooldown = false) { }

	protected virtual void OnDestroy() { }

	public virtual void OnLivesLost(bool fromLeak) { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void OnPreLivesLost(bool fromLeak) { }

	private void OnRoundStartSim(int roundNumber) { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public virtual void PerformCustomUIAction() { }

	public void Process(int elapsed) { }

	public void RefreshCooldown() { }

	public void set_CooldownRemaining(float value) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

