namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(MoveBack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoveBackModel : ProjectileBehaviorModel
{
	internal class MoveBackMutator : BehaviorMutator
	{
		public MoveBackModel moveBackModel; //Field offset: 0x70

		public MoveBackMutator(MoveBackModel moveBackModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x3C
	public int lifespanFrames; //Field offset: 0x40
	public int layers; //Field offset: 0x44
	public string mutationId; //Field offset: 0x48
	private MoveBackMutator mutator; //Field offset: 0x50

	public MoveBackMutator Mutator
	{
		 get { } //Length: 209
	}

	public MoveBackModel(string name, float multiplier, float lifespan, string mutationId, int layers) { }

	public virtual Model Clone() { }

	public MoveBackMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

