namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Freeze), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FreezeModel : ProjectileBehaviorWithOverlayModel
{
	internal class Mutator : BehaviorMutator
	{
		public float speed; //Field offset: 0x70
		public string overlayType; //Field offset: 0x78
		public string mutationId; //Field offset: 0x80
		public GrowBlockModel growBlockModel; //Field offset: 0x88
		public DamageModel damageModel; //Field offset: 0x90
		public bool canFreezeMoabs; //Field offset: 0x98

		public Mutator(float speed, string overlayType, string mutationId, GrowBlockModel growBlockModel, DamageModel damageModel, bool canFreezeMoabs) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float speed; //Field offset: 0x40
	public int layers; //Field offset: 0x44
	public string mutationId; //Field offset: 0x48
	public float percentChanceToFreeze; //Field offset: 0x50
	public bool enablePercentChanceToFreeze; //Field offset: 0x54
	[SerializeReference]
	public DamageModel damageModel; //Field offset: 0x58
	public bool canFreezeMoabs; //Field offset: 0x60
	public bool cascadeMutators; //Field offset: 0x61
	public GrowBlockModel growBlockModel; //Field offset: 0x68
	public bool applyAfterDamage; //Field offset: 0x70
	[SerializeField]
	private float lifespan; //Field offset: 0x74
	public int lifespanFrames; //Field offset: 0x78
	private Mutator _mutator; //Field offset: 0x80

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public Mutator mutator
	{
		 get { } //Length: 349
	}

	public FreezeModel(string name, float speed, float lifespan, string mutationId, int layers, string overlayType, bool cascadeMutators, GrowBlockModel growBlockModel, DamageModel damageModel, float percentChanceToFreeze, bool enablePercentChanceToFreeze, bool canFreezeMoabs, bool applyAfterDamage) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public Mutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

}

