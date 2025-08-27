namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(ThrowBloonsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ThrowBloonsActionModel : BloonBehaviorActionModel
{
	internal class AddBehaviorToBloonMutator : BehaviorMutator
	{
		private readonly float speedMultiplier; //Field offset: 0x70
		private readonly float offsetMin; //Field offset: 0x74
		private readonly float offsetMax; //Field offset: 0x78

		public AddBehaviorToBloonMutator(string id, float speedMultiplier, float offsetMin, float offsetMax) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public bool addCamo; //Field offset: 0x38
	public float speedMultiplier; //Field offset: 0x3C
	public float offsetMin; //Field offset: 0x40
	public float offsetMax; //Field offset: 0x44
	private AddBehaviorToBloonMutator _mutator; //Field offset: 0x48

	public AddBehaviorToBloonMutator mutator
	{
		 get { } //Length: 308
	}

	public ThrowBloonsActionModel() { }

	public ThrowBloonsActionModel(string name, string actionId, bool addCamo, float speedMultiplier, float offsetMin, float offsetMax) { }

	public virtual Model Clone() { }

	public AddBehaviorToBloonMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

