namespace Assets.Scripts.Models.Towers.Mods;

public class BouncingDartsModModel : MutatorModModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Model> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Mutate>b__2_0(Model behavior) { }

	}

	public string targets; //Field offset: 0x30

	public BouncingDartsModModel(string name, string targets = "") { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

