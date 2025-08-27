namespace Assets.Scripts.Models.Towers.PlacementBehaviors;

public abstract class PlacementBehaviorModel : TowerBehaviorModel
{

	protected PlacementBehaviorModel(string name) { }

	public override BehaviorMutator GetMutator(AreaType areaType) { }

	public override Vector3 SetPlacerTransform(Vector3 placerTransform, Area[] areas) { }

}

