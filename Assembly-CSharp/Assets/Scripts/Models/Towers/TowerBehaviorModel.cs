namespace Assets.Scripts.Models.Towers;

public abstract class TowerBehaviorModel : EntityBehaviorModel
{

	protected TowerBehaviorModel(string name) { }

	public override IEnumerable<Mesh> GetAdditionalDisplayMeshes(Simulation sim, TowerModel towerModel, Vector3 position, bool isFromHover) { }

}

