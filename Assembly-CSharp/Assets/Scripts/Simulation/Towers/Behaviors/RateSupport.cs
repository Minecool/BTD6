namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RateSupport : Support
{
	public RateSupportModel rateSupportModel; //Field offset: 0x90

	public RateSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

