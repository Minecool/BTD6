namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Knockback), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class KnockbackModel : ProjectileBehaviorModel
{
	internal class KnockbackMutator : BehaviorMutator
	{
		private float lightMultiplier; //Field offset: 0x70
		private float moabMultiplier; //Field offset: 0x74
		private float heavyMultiplier; //Field offset: 0x78

		public KnockbackMutator(string mutationId, float lightMultiplier, float moabMultiplier, float heavyMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float moabMultiplier; //Field offset: 0x38
	public float heavyMultiplier; //Field offset: 0x3C
	public float lightMultiplier; //Field offset: 0x40
	public string mutationId; //Field offset: 0x48
	[SerializeField]
	private float lifespan; //Field offset: 0x50
	public int lifespanFrames; //Field offset: 0x54
	private KnockbackMutator _mutator; //Field offset: 0x58

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public KnockbackMutator mutator
	{
		 get { } //Length: 325
	}

	public KnockbackModel(string name, float moabMultiplier, float heavyMultiplier, float lightMultiplier, float lifespan, string mutationId, KnockbackMutator mutator = null) { }

	public virtual Model Clone() { }

	public void CreateMutator() { }

	public float get_Lifespan() { }

	public KnockbackMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

