namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DistributeToChildrenBloonModifier), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DistributeToChildrenBloonModifierModel : ProjectileBehaviorModel
{
	internal class Mutator : BehaviorMutator
	{

		public Mutator(string id) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string bloonTag; //Field offset: 0x38
	public String[] bloonTags; //Field offset: 0x40
	private Mutator _mutator; //Field offset: 0x48

	public Mutator mutator
	{
		 get { } //Length: 224
	}

	public DistributeToChildrenBloonModifierModel(string name, string tag, Mutator mutator = null) { }

	public virtual Model Clone() { }

	public Mutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

