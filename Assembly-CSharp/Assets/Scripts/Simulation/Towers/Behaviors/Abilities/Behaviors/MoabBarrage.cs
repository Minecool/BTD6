namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class MoabBarrage : AbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Bloon, Boolean> <>9__5_0; //Field offset: 0x8
		public static Func<Bloon, Single> <>9__5_1; //Field offset: 0x10
		public static Func<Bloon, Single> <>9__5_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <Activate>b__5_0(Bloon bloon) { }

		internal float <Activate>b__5_1(Bloon bloon) { }

		internal float <Activate>b__5_2(Bloon bloon) { }

	}

	public MoabBarrageModel moabBarrageModel; //Field offset: 0x68
	private DisplayBehavior display; //Field offset: 0x70

	public MoabBarrage() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

