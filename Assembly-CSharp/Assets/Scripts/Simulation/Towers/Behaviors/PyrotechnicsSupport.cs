namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PyrotechnicsSupport : Support
{
	public class PyrotechnicsSupportMutator : BehaviorMutator
	{
		private readonly float percentIncrease; //Field offset: 0x70

		public PyrotechnicsSupportMutator(bool isUnique, string mutatorId, float percentIncrease, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public PyrotechnicsSupportModel pyrotechnicsSupport; //Field offset: 0x90

	public PyrotechnicsSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

