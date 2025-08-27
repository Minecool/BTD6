namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddBehaviorToBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddBehaviorToBloonModel : ProjectileBehaviorWithOverlayModel
{
	internal class Mutator : BehaviorMutator
	{
		public BloonBehaviorModel[] behaviors; //Field offset: 0x70
		public string overlayType; //Field offset: 0x78
		public string mutationId; //Field offset: 0x80

		public Mutator(BloonBehaviorModel[] behaviors, string mutationId, string overlayType, bool isUnique = true, bool lastAppliesFirst = false, int glueLevel = 0, int stackCount = 0, bool dontCopy = false, bool dontRemoveOnBloonDegrade = false) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string mutationId; //Field offset: 0x40
	public int layers; //Field offset: 0x48
	[SerializeField]
	private float lifespan; //Field offset: 0x4C
	public int lifespanFrames; //Field offset: 0x50
	[SerializeReference]
	public FilterModel filter; //Field offset: 0x58
	[SerializeReference]
	public FilterModel[] filters; //Field offset: 0x60
	[SerializeReference]
	public BloonBehaviorModel[] behaviors; //Field offset: 0x68
	public bool isUnique; //Field offset: 0x70
	public bool lastAppliesFirst; //Field offset: 0x71
	public bool collideThisFrame; //Field offset: 0x72
	public bool cascadeMutators; //Field offset: 0x73
	public int glueLevel; //Field offset: 0x74
	public bool applyOnlyIfDamaged; //Field offset: 0x78
	public int stackCount; //Field offset: 0x7C
	public bool dontCopy; //Field offset: 0x80
	public DamageModel parentDamageModel; //Field offset: 0x88
	public float chance; //Field offset: 0x90
	public bool dontRemoveOnBloonDegrade; //Field offset: 0x94
	private Dictionary<ObjectId, Mutator> mutators; //Field offset: 0x98

	public AddBehaviorToBloonModel(string name, string mutationId, float lifespan, int layers, FilterModel filter, FilterModel[] filters, BloonBehaviorModel[] behaviors, string overlayType, bool isUnique, bool lastAppliesFirst, bool collideThisFrame, bool cascadeMutators, int glueLevel, bool applyOnlyIfDamaged, int stackCount, DamageModel parentDamageModel, bool dontCopy, float chance, bool dontRemoveOnBloonDegrade) { }

	public virtual Model Clone() { }

	public Mutator GetMutatorForTower(Tower tower) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

