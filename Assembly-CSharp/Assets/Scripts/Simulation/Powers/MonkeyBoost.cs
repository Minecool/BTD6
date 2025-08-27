namespace Assets.Scripts.Simulation.Powers;

public class MonkeyBoost : Power
{
	internal class MonkeyBoostMutator : BehaviorMutator
	{
		private MonkeyBoostModel monkeyBoostModel; //Field offset: 0x70

		public MonkeyBoostMutator(MonkeyBoostModel overclockModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}


	public MonkeyBoost() { }

	public virtual void Activate(Vector2 location, PowerBehaviorModel model, int inputId) { }

	public virtual bool CheckLocation(Vector2 location, PowerBehaviorModel model) { }

}

