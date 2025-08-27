namespace Assets.Scripts.Simulation.Powers;

public class Thrive : Power
{
	internal class ThriveMutator : BehaviorMutator
	{
		private ThriveModel thriveModel; //Field offset: 0x70

		public ThriveMutator(ThriveModel thriveModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public ThriveModel thriveModel; //Field offset: 0x18
	public ThriveMutator mutator; //Field offset: 0x20
	public int roundsLeft; //Field offset: 0x28
	public IncreaseBloonWorthSimBehavior increaseBloonWorthSimBehavior; //Field offset: 0x30

	public Thrive() { }

	public virtual void Activate(Vector2 location, PowerBehaviorModel model, int inputId) { }

	public bool CanActivate() { }

	public virtual bool CheckLocation(Vector2 location, PowerBehaviorModel model) { }

	public void OnLost() { }

	public void OnRoundStart(int roundSpawned) { }

	private void RemoveThrive() { }

}

