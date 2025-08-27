namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PlayAnimationIndex : TowerBehavior
{
	public PlayAnimationIndexModel playAnimationOnUpgradeModel; //Field offset: 0x68
	private int animationToSet; //Field offset: 0x70
	private bool ignoreThisFrame; //Field offset: 0x74

	public PlayAnimationIndex() { }

	public void IgnoreThisFrame() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void Process(int elapsed) { }

	public void SetAnimationState(int state) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

