namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public abstract class BoostArtifactBehavior : ArtifactBehaviorBase
{
	public BoostArtifact boostArtifact; //Field offset: 0x68
	public BoostArtifactBehaviorModel boostBehaviorModel; //Field offset: 0x70

	protected BoostArtifactBehavior() { }

	public virtual void GetModifiedPlacementModel(ref TowerModel clonedTowerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsChangingPlacementModel(TowerModel towerModel) { }

	public override BehaviorMutator Mutator() { }

	public override void OnTowerEnterZone(Tower tower) { }

	public override void OnTowerExitZone(Tower tower) { }

}

