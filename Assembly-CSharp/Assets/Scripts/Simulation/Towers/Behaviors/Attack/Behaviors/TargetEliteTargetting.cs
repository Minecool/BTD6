namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetEliteTargetting : TargetCamo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Target, Bloon> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Bloon <GetTargets>b__8_0(Target x) { }

	}

	public TargetEliteTargettingModel targetEliteTargettingModel; //Field offset: 0x78
	private float moabTypeBuffer; //Field offset: 0x80
	private float exitBuffer; //Field offset: 0x84
	private float moreThanOneChildBuffer; //Field offset: 0x88
	private float camoPriority; //Field offset: 0x8C

	public TargetEliteTargetting() { }

	public virtual string GetName() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public float Sort(Bloon bloon) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

