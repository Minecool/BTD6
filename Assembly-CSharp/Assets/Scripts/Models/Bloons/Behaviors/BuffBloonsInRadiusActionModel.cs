namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(BuffBloonsInRadiusAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BuffBloonsInRadiusActionModel : BloonBehaviorActionModel
{
	internal class BloonBuffMutator : BehaviorMutator
	{
		public float speedMultiplier; //Field offset: 0x70

		public BloonBuffMutator(float speedMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float radius; //Field offset: 0x38
	public float speedMultiplier; //Field offset: 0x3C
	private BloonBuffMutator mutator; //Field offset: 0x40

	public BloonBuffMutator Mutator
	{
		 get { } //Length: 237
	}

	public BuffBloonsInRadiusActionModel() { }

	public BuffBloonsInRadiusActionModel(string name, string actionId, float radius, float speedMultiplier) { }

	public virtual Model Clone() { }

	public BloonBuffMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

