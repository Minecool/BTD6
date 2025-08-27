namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DistributeToChildrenSet), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DistributeToChildrenSetModel : ProjectileBehaviorModel
{
	internal class Mutator : BehaviorMutator
	{

		public Mutator(string mutationId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int layers; //Field offset: 0x38
	private Mutator _mutator; //Field offset: 0x40

	public Mutator mutator
	{
		 get { } //Length: 220
	}

	public DistributeToChildrenSetModel(string name, int layers, Mutator mutator = null) { }

	public virtual Model Clone() { }

	public Mutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

