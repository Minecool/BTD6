namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BananaFarmerRegrowBananas : TowerBehaviorBuff
{
	public BananaFarmerRegrowBananasModel bananaFarmerRegrowBananasModel; //Field offset: 0x70
	private Tower linkedTower; //Field offset: 0x78
	private Entity linkedTowerDisplay; //Field offset: 0x80
	private readonly List<Entity> lineDotDisplays; //Field offset: 0x88
	private bool drawDots; //Field offset: 0x90
	private Zoned<Tower> zone; //Field offset: 0x98
	private ISelectable selectedObj; //Field offset: 0xA0

	public BananaFarmerRegrowBananas() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	private void CheckConnectedDisplay() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual string GetTowerBehaviorCustomInputClass(string buttonId) { }

	public virtual object GetTowerBehaviorCustomInputData(string buttonId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selected) { }

	private void PlayConfirmSound() { }

	private void PlotPointsToLinkedTower() { }

	private void Process(int elapsed) { }

	private float Range() { }

	private void RemoveDisplays() { }

	private void RemoveDots() { }

	private void RemoveLinkedTowerDisplay() { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	private void TowerEnter(Tower behavior) { }

	private void TowerExit(Tower behavior) { }

	private bool TowerFilter(RootBehavior behavior) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

