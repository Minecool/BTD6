namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddBonusDamagePerHitToBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddBonusDamagePerHitToBloonModel : ProjectileBehaviorModel
{
	internal class Mutator : BehaviorMutator
	{
		public float perHitDamageAddition; //Field offset: 0x70
		public string overlayType; //Field offset: 0x78

		public Mutator(string mutationId, float perHitDamageAddition, string overlayType, bool isUnique = true, bool lastAppliesFirst = false) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string mutationId; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x40
	public int lifespanFrames; //Field offset: 0x44
	public float perHitDamageAddition; //Field offset: 0x48
	public int layers; //Field offset: 0x4C
	public bool isUnique; //Field offset: 0x50
	public bool lastAppliesFirst; //Field offset: 0x51
	public bool cascadeMutators; //Field offset: 0x52
	public string overlayType; //Field offset: 0x58
	private Mutator _mutator; //Field offset: 0x60

	public Mutator mutator
	{
		 get { } //Length: 300
	}

	public AddBonusDamagePerHitToBloonModel(string name, string mutationId, float lifespan, float perHitDamageAddition, int layers, bool isUnique, bool lastAppliesFirst, bool cascadeMutators, string overlayType) { }

	public virtual Model Clone() { }

	public Mutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

