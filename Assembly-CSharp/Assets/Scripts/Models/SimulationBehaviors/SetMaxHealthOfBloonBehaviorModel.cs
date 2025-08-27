namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(SetMaxHealthOfBloonBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetMaxHealthOfBloonBehaviorModel : SimulationBehaviorModel
{
	internal class SetMaxHealthForBloon : BehaviorMutator
	{
		public float maxHealthMultiplier; //Field offset: 0x70

		public SetMaxHealthForBloon(string name, float maxHealthMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string bloonId; //Field offset: 0x30
	public float healthMultiplier; //Field offset: 0x38
	public int round; //Field offset: 0x3C
	private SetMaxHealthForBloon mutator; //Field offset: 0x40

	public SetMaxHealthForBloon Mutator
	{
		 get { } //Length: 250
	}

	public SetMaxHealthOfBloonBehaviorModel(string name, string bloonId, float healthMultiplier, int round) { }

	public virtual Model Clone() { }

	public SetMaxHealthForBloon get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

