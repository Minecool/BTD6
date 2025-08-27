namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(BuffBloonSpeed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BuffBloonSpeedModel : BloonBehaviorModel
{
	internal class BloonBuffMutator : BehaviorMutator
	{
		public float speedMultiplier; //Field offset: 0x70
		public string overlayId; //Field offset: 0x78

		public BloonBuffMutator(float speedMultiplier, string overlayId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float speedBoost; //Field offset: 0x30
	public float debuffInRadius; //Field offset: 0x34
	public string speedBoostOverlayGroup; //Field offset: 0x38
	private BloonBuffMutator mutator; //Field offset: 0x40

	public BloonBuffMutator Mutator
	{
		 get { } //Length: 257
	}

	public BuffBloonSpeedModel() { }

	public BuffBloonSpeedModel(string name, float speedBoost, float debuffInRadius, string speedBoostOverlayGroup) { }

	public virtual Model Clone() { }

	public BloonBuffMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

