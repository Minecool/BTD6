namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(OverclockPermanent), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OverclockPermanentModel : AbilityBehaviorModel
{
	internal class OverclockPermanentMutator : BehaviorMutator
	{
		private readonly OverclockPermanentModel overclockPermanentModel; //Field offset: 0x70
		public int stacks; //Field offset: 0x78

		public OverclockPermanentMutator(OverclockPermanentModel overclockPermanentModel, int stacks) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

		public virtual int StackCount() { }

	}

	public static string MutatorId; //Field offset: 0x0
	public float rateModifier; //Field offset: 0x30
	public float villageRangeModifier; //Field offset: 0x34
	public int maxStacks; //Field offset: 0x38
	public string buffLocsName; //Field offset: 0x40
	public string buffIconName; //Field offset: 0x48
	public Dictionary<Int32, OverclockPermanentMutator> mutatorsByStack; //Field offset: 0x50

	private static OverclockPermanentModel() { }

	public OverclockPermanentModel(string name, float rateModifier, float villageRangeModifier, int maxStacks, Dictionary<Int32, OverclockPermanentMutator> mutatorsByStack, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public OverclockPermanentMutator MutatorByStack(int stack) { }

}

