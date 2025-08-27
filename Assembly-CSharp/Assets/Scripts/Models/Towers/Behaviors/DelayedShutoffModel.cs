namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DelayedShutoff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DelayedShutoffModel : TowerBehaviorModel
{
	internal class ShutoffMutator : BehaviorMutator
	{

		public ShutoffMutator() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[SerializeField]
	private float delay; //Field offset: 0x30
	public int delayFrames; //Field offset: 0x34
	[SerializeField]
	private float shutoffTime; //Field offset: 0x38
	public int shutoffTimeFrames; //Field offset: 0x3C
	private ShutoffMutator mutator; //Field offset: 0x40
	public EffectModel effectModel; //Field offset: 0x48

	public ShutoffMutator Mutator
	{
		 get { } //Length: 207
	}

	public DelayedShutoffModel(string name, float delay, float shutoffTime, EffectModel effectModel) { }

	public virtual Model Clone() { }

	public ShutoffMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

