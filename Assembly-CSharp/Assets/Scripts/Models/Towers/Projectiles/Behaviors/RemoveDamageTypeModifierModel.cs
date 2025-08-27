namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RemoveDamageTypeModifier), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveDamageTypeModifierModel : ProjectileBehaviorModel
{
	internal class RemoveDamageTypeModifierMutator : BehaviorMutator
	{
		private BloonProperties bloonPropertiesToRemove; //Field offset: 0x70

		public RemoveDamageTypeModifierMutator(string mutationId, BloonProperties bloonPropertiesToRemove) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[SerializeField]
	private float lifespan; //Field offset: 0x38
	public int lifespanFrames; //Field offset: 0x3C
	public int layers; //Field offset: 0x40
	public string mutationId; //Field offset: 0x48
	public bool removeAll; //Field offset: 0x50
	public BloonProperties bloonPropertiesToRemove; //Field offset: 0x54
	private RemoveDamageTypeModifierMutator _mutator; //Field offset: 0x58

	public RemoveDamageTypeModifierMutator mutator
	{
		 get { } //Length: 231
	}

	public RemoveDamageTypeModifierModel(string name, float lifespan, string mutationId, int layers, BloonProperties bloonPropertiesToRemove, RemoveDamageTypeModifierMutator mutator = null) { }

	public virtual Model Clone() { }

	public RemoveDamageTypeModifierMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

