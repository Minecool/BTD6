namespace Assets.Scripts.Simulation.Objects;

public interface ITowerBehavior : IEntityBehavior
{

	public void ApplyCustomInputData(CustomInputData data) { }

	public bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	public IEnumerable<Mesh> GetAdditionalDisplayMeshes(TowerModel towerModel, Vector3 position, bool isFromHover) { }

	public float GetAdditionalSaleAmounts() { }

	public string GetTowerBehaviorCustomInputClass(string buttonId) { }

	public object GetTowerBehaviorCustomInputData(string buttonId) { }

	public bool IfZeroSaleTower() { }

	public void OnRangeChanged() { }

	public void OnTowerCrit(Projectile projectile) { }

	public void OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info) { }

	public void PerformCustomUIAction() { }

	public float TransformSalePerc() { }

}

