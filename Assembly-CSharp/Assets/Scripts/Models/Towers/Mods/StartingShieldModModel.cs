namespace Assets.Scripts.Models.Towers.Mods;

public class StartingShieldModModel : MutatorModModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<SimulationBehaviorModel> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Mutate>b__4_0(SimulationBehaviorModel x) { }

	}

	public float startingShield; //Field offset: 0x30
	public float maxShield; //Field offset: 0x34
	public float shieldPerRound; //Field offset: 0x38

	public StartingShieldModModel(string name, float startingShield, float maxShield, float shieldPerRound) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

