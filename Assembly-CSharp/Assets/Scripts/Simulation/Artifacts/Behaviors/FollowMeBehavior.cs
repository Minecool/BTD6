namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class FollowMeBehavior : ItemArtifactBehavior
{
	public FollowMeBehaviorModel followMeBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public BehaviorMutator Mutator
	{
		 get { } //Length: 8
	}

	public FollowMeBehavior() { }

	public BehaviorMutator get_Mutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsTowerValid(TowerModel towerModel) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateMutators(Tower updatedTower = null, Tower ignoreTower = null) { }

}

