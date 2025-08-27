namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(FlightBoostAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FlightBoostAbilityModel : AbilityBehaviorModel
{
	internal class AirUnitMutator : BehaviorMutator
	{
		private readonly float moveSpeedMultiplier; //Field offset: 0x70

		public AirUnitMutator(float moveSpeedMultiplier, BuffIndicatorModel buffIndicatorModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "FlightBoost"; //Field offset: 0x0
	public float lifespan; //Field offset: 0x30
	public int lifespanFrames; //Field offset: 0x34
	public float moveSpeedMultiplier; //Field offset: 0x38
	public EffectModel effectDuringWorkshopModel; //Field offset: 0x40
	public EffectModel effectDuringHeroModel; //Field offset: 0x48
	public int animationStateOnEnd; //Field offset: 0x50
	private AirUnitMutator _mutator; //Field offset: 0x58

	public AirUnitMutator Mutator
	{
		 get { } //Length: 307
	}

	public FlightBoostAbilityModel(string name, float lifespan, float moveSpeedMultiplier, EffectModel effectDuringWorkshopModel, EffectModel effectDuringHeroModel, int animationStateOnEnd) { }

	public virtual Model Clone() { }

	public AirUnitMutator get_Mutator() { }

	public BuffIndicatorModel GetBuffIndicatorModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

