namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(IncreaseBloonWorthWithTier), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IncreaseBloonWorthWithTierModel : ProjectileBehaviorWithOverlayModel
{
	internal class BloonWorthMutator : BehaviorMutator
	{
		private readonly float cashPerTier; //Field offset: 0x70
		public string overlayType; //Field offset: 0x78

		public BloonWorthMutator(string id, float cashPerTier, string overlayType) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public string mutatorId; //Field offset: 0x40
	public float cashPerTier; //Field offset: 0x48
	private BloonWorthMutator _mutator; //Field offset: 0x50

	public BloonWorthMutator mutator
	{
		 get { } //Length: 265
	}

	public IncreaseBloonWorthWithTierModel(string name, string mutatorId, float cashPerTier, string overlayType, BloonWorthMutator mutator = null) { }

	public virtual Model Clone() { }

	public BloonWorthMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void ResetMutator() { }

}

