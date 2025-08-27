namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(IncreaseBloonWorth), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IncreaseBloonWorthModel : ProjectileBehaviorWithOverlayModel
{
	internal class BloonWorthMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70
		private readonly float additive; //Field offset: 0x74
		public string overlayType; //Field offset: 0x78
		public BloonProperties bloonPropertiesToRemove; //Field offset: 0x80

		public BloonWorthMutator(string id, float multiplier, float additive, string overlayType, BloonProperties bloonPropertiesToRemove) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string mutatorId; //Field offset: 0x40
	public float cash; //Field offset: 0x48
	public float cashMultiplier; //Field offset: 0x4C
	public FilterModel filter; //Field offset: 0x50
	public int charges; //Field offset: 0x58
	public BloonProperties bloonPropertiesToRemove; //Field offset: 0x5C
	[SerializeField]
	private float duration; //Field offset: 0x60
	public int durationFrames; //Field offset: 0x64
	private BloonWorthMutator _mutator; //Field offset: 0x68

	public BloonWorthMutator mutator
	{
		 get { } //Length: 314
	}

	public IncreaseBloonWorthModel(string name, string mutatorId, float cash, float cashMultiplier, FilterModel filter, int charges, string overlayType, float duration, BloonProperties bloonPropertiesToRemove, BloonWorthMutator mutator = null) { }

	public virtual Model Clone() { }

	public BloonWorthMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void ResetMutator() { }

}

