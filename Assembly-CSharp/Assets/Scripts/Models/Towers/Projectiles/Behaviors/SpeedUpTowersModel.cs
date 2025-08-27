namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SpeedUpTowers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpeedUpTowersModel : ProjectileBehaviorModel
{
	internal class SpeedUpMutator : BehaviorMutator
	{
		private float increase; //Field offset: 0x70

		public SpeedUpMutator(float increase, bool isUnique, string id, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float increase; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x3C
	[SerializeField]
	private float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44
	public bool useClosest; //Field offset: 0x48
	public string mutatorId; //Field offset: 0x50
	public int priority; //Field offset: 0x58
	private SpeedUpMutator mutator; //Field offset: 0x60

	public SpeedUpMutator Mutator
	{
		 get { } //Length: 307
	}

	public SpeedUpTowersModel(string name, float increase, float lifespan, bool isUnique, bool useClosest, string mutatorId, int priority) { }

	public virtual Model Clone() { }

	public SpeedUpMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

