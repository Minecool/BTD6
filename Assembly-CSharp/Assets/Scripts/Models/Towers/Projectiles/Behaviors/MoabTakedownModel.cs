namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(MoabTakedown), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoabTakedownModel : ProjectileBehaviorModel
{
	internal class BloonWorthMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70
		private readonly float additive; //Field offset: 0x74
		private readonly IncreaseWorthTextEffectModel behavior; //Field offset: 0x78

		public BloonWorthMutator(string id, float multiplier, float additive, IncreaseWorthTextEffectModel behavior) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[SerializeField]
	private float speed; //Field offset: 0x38
	public float speedFrames; //Field offset: 0x3C
	public bool increaseMoabBloonWorth; //Field offset: 0x40
	public float multiplier; //Field offset: 0x44
	public float additive; //Field offset: 0x48
	public IncreaseWorthTextEffectModel increaseWorthTextEffectModel; //Field offset: 0x50
	public float destroyBloonRadius; //Field offset: 0x58
	public PrefabReference displayAtEjectId; //Field offset: 0x60
	private BloonWorthMutator _bloonWorthMutator; //Field offset: 0x68

	public BloonWorthMutator bloonWorthMutator
	{
		 get { } //Length: 306
	}

	public MoabTakedownModel(string name, float speed, bool increaseMoabBloonWorth, float multiplier, float additive, IncreaseWorthTextEffectModel increaseWorthTextEffectModel, float destroyBloonRadius, PrefabReference displayAtEjectId) { }

	public virtual Model Clone() { }

	public BloonWorthMutator get_bloonWorthMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

