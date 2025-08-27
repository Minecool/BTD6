namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RangeUpTowers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RangeUpTowersModel : ProjectileBehaviorModel
{
	internal class RangeUpMutator : BehaviorMutator
	{
		private float increase; //Field offset: 0x70

		public RangeUpMutator(float increase, bool isUnique, string id, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float increase; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x3C
	public bool useClosest; //Field offset: 0x3D
	[SerializeField]
	private float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44
	public string mutatorId; //Field offset: 0x48
	public int priority; //Field offset: 0x50
	private RangeUpMutator mutator; //Field offset: 0x58

	public RangeUpMutator Mutator
	{
		 get { } //Length: 311
	}

	public RangeUpTowersModel(string name, float increase, float lifespan, bool isUnique, bool useClosest, string mutatorId, int priority) { }

	public virtual Model Clone() { }

	public RangeUpMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

