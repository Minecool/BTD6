namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class AddBossSkinMutator : BehaviorMutator
{
	public string bossName; //Field offset: 0x70

	public AddBossSkinMutator(string id, string bossName) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

