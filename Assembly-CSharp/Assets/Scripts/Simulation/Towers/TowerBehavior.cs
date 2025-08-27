namespace Assets.Scripts.Simulation.Towers;

public abstract class TowerBehavior : EntityBehavior, ITowerBehavior, IEntityBehavior
{
	public Tower tower; //Field offset: 0x60

	protected TowerBehavior() { }

	public override void ApplyCustomInputData(CustomInputData data) { }

	public virtual void Cleanup() { }

	public override bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	public override IEnumerable<Mesh> GetAdditionalDisplayMeshes(TowerModel towerModel, Vector3 position, bool isFromHover) { }

	public override float GetAdditionalSaleAmounts() { }

	public override float GetModifiedLeakLivesLost(Bloon leakedBloon, float livesToLose) { }

	public override string GetTowerBehaviorCustomInputClass(string buttonId) { }

	public override object GetTowerBehaviorCustomInputData(string buttonId) { }

	public override bool IfZeroSaleTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void OnRangeChanged() { }

	public override void OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info) { }

	public override void PerformCustomUIAction() { }

	public override float TransformSalePerc() { }

	public virtual float TransformXp(float xp) { }

}

