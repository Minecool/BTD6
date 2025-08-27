namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class TechBotLink : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AbilityBehavior, Boolean> <>9__30_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Process>b__30_0(AbilityBehavior b) { }

	}

	private const float travelDisplayPostLifetime = 0.2; //Field offset: 0x0
	public TechBotLinkModel techBotLinkModel; //Field offset: 0x68
	private Tower linkedTower; //Field offset: 0x70
	private readonly List<Ability> linkedAbilities; //Field offset: 0x78
	private Int32[] linkedTowerTiers; //Field offset: 0x80
	private Entity linkedTowerDisplay; //Field offset: 0x88
	private readonly List<Entity> lineDotDisplays; //Field offset: 0x90
	private bool drawDots; //Field offset: 0x98
	private Entity travelDisplay; //Field offset: 0xA0
	private float travelDisplayPostLifetimeCurrent; //Field offset: 0xA8
	private bool isTravelDisplayInPostLifetime; //Field offset: 0xAC
	private AmbushTech ambushTech; //Field offset: 0xB0
	private ObjectId selectedTowerId; //Field offset: 0xB8
	private ISelectable selectedObj; //Field offset: 0xC0

	public Tower LinkedTower
	{
		 get { } //Length: 5
	}

	public TechBotLink() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual bool CanUseAbility() { }

	private void CheckConnectedDisplay() { }

	private void DestroyTravelDisplay() { }

	private bool DoesTowerHaveValidAbilities(Tower tower) { }

	public Tower get_LinkedTower() { }

	public AmbushTech GetAmbushTech() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	private DisplayBehavior GetRotatingDisplay() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBanned(Tower tower) { }

	private bool IsTowerAlreadyLinked(Tower tower) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	public void LinkTower(Tower tower) { }

	protected virtual void OnDestroy() { }

	public virtual void OnPlace() { }

	private void OnSelectionChanged(ISelectable selected) { }

	public void OnTowerOwnerReassigned() { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	private void PlayActivateSound() { }

	private void PlayConfirmSound() { }

	private void PlotPointsToLinkedTower() { }

	private void Process(int elapsed) { }

	private void RemoveDisplays() { }

	private void RemoveDots() { }

	private void RemoveLinkedTowerDisplay() { }

	public void SetAnimation(int animation) { }

	public void SetRotation(float rotation) { }

	public virtual bool ShowInAbilityMenu() { }

	public void UnlinkTower() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateTravelEffect() { }

}

