namespace Assets.Scripts.Simulation.Props;

public class DisableTowersInRange : PropBehavior
{
	public DisableTowersInRangeModel behaviorModel; //Field offset: 0x68

	public DisableTowersInRange() { }

	public virtual void DoAfterMapLoad() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnVisibilityToggled(bool isVisible) { }

	private void ToggleTowerSuspension(bool suspend) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

