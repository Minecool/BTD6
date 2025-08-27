namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(LongArmOfLight), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LongArmOfLightModel : AbilityBehaviorModel
{
	internal class LongArmOfLightMutator : BehaviorMutator
	{
		private readonly LongArmOfLightModel longArmOfLightModel; //Field offset: 0x70

		public LongArmOfLightMutator(LongArmOfLightModel longArmOfLightModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x30
	public AssetPathModel projectileDisplay; //Field offset: 0x38
	public float projectileRadiusMultiplier; //Field offset: 0x40
	public BloonProperties immuneBloonProperties; //Field offset: 0x44
	public int damageIncrease; //Field offset: 0x48
	public string mutatorId; //Field offset: 0x50
	[SerializeField]
	private float lifespan; //Field offset: 0x58
	public int lifespanFrames; //Field offset: 0x5C
	private LongArmOfLightMutator _mutator; //Field offset: 0x60

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public LongArmOfLightMutator mutator
	{
		 get { } //Length: 213
	}

	public LongArmOfLightModel(string name, float lifespan, float multiplier, AssetPathModel projectileDisplay, float projectileRadiusMultiplier, BloonProperties immuneBloonProperties, int damageIncrease, string mutatorId) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public LongArmOfLightMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

