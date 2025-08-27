namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class InvokeBoostBuffBehavior : ItemArtifactBehavior
{
	public InvokeBoostBuffBehaviorModel invokeBoostBuffBehaviorModel; //Field offset: 0x78
	private BoostArtifact invokedBoost; //Field offset: 0x80

	public BoostArtifact InvokedBoost
	{
		 get { } //Length: 8
	}

	public InvokeBoostBuffBehavior() { }

	public BoostArtifact get_InvokedBoost() { }

	public virtual float GetDiscount(Tower tower, int path, int tier) { }

	public virtual void GetModifiedPlacementModel(ref TowerModel clonedTowerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsChangingPlacementModel(TowerModel towerModel) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

