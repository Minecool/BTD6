namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MagmaPool), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MagmaPoolModel : TowerBehaviorModel
{
	internal class MagmaMutator : BehaviorMutator
	{
		public float rateMultiplier; //Field offset: 0x70
		public float rangeMultiplier; //Field offset: 0x74

		public MagmaMutator(string id, float rateMultiplier, float rangeMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorID = "MagmaDebuff"; //Field offset: 0x0
	public float radius; //Field offset: 0x30
	public float rateMultiplier; //Field offset: 0x34
	public float rangeMultiplier; //Field offset: 0x38
	private MagmaMutator mutator; //Field offset: 0x40

	public MagmaMutator Mutator
	{
		 get { } //Length: 289
	}

	public MagmaPoolModel(string name, float radius, float rateMultiplier, float rangeMultiplier) { }

	public virtual Model Clone() { }

	public MagmaMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

