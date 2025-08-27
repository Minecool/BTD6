namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(AbilityCooldownZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AbilityCooldownZoneModel : BloonBehaviorModel
{
	internal class CooldownMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public CooldownMutator(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x30
	private CooldownMutator mutator; //Field offset: 0x38

	public CooldownMutator Mutator
	{
		 get { } //Length: 252
	}

	public AbilityCooldownZoneModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	public CooldownMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

