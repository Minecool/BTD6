namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CallToArms), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CallToArmsModel : AbilityBehaviorModel
{
	internal class CallToArmsMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public CallToArmsMutator(float multiplier, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x30
	public bool useRadius; //Field offset: 0x34
	public string buffLocsName; //Field offset: 0x38
	public string buffIconName; //Field offset: 0x40
	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C
	private CallToArmsMutator _mutator; //Field offset: 0x50

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public CallToArmsMutator Mutator
	{
		 get { } //Length: 295
	}

	public CallToArmsModel(string name, float lifespan, float multiplier, bool useRadius, string buffLocsName, string buffIconName, CallToArmsMutator mutator = null) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public CallToArmsMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

