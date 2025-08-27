namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SpeedUpMutator : BehaviorMutator
{
	private float speedMultiplier; //Field offset: 0x70

	public SpeedUpMutator(string id, float speedMultiplier) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

