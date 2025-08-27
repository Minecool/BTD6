namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(BloonSlap), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BloonSlapModel : ProjectileBehaviorModel
{
	internal class SlapMutator : BehaviorMutator
	{
		public float heavySlow; //Field offset: 0x70
		public float lightSlow; //Field offset: 0x74

		public SlapMutator(string id, float heavySlow, float lightSlow) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int valueForNormalBloons; //Field offset: 0x38
	public int valueForCeramicBloons; //Field offset: 0x3C
	public int heavyMultiplier; //Field offset: 0x40
	public int lightMultiplier; //Field offset: 0x44
	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C
	public string mutationId; //Field offset: 0x50
	private SlapMutator mutator; //Field offset: 0x58

	public SlapMutator Mutator
	{
		 get { } //Length: 269
	}

	public BloonSlapModel(string name, int valueForNormalBloons, int valueForCeramicBloons, int heavyMultiplier, int lightMultiplier, float lifespan, string mutationId) { }

	public virtual Model Clone() { }

	public SlapMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

