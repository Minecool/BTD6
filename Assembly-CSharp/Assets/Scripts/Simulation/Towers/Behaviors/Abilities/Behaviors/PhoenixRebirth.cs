namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class PhoenixRebirth : MagusPerfectusAbilityBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Tower, Boolean> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_DarkPhoenix>b__3_0(Tower x) { }

	}

	private int reactivateAt; //Field offset: 0x68
	private SingleEmission singleEmission; //Field offset: 0x70
	public PhoenixRebirthModel behaviourModel; //Field offset: 0x78

	private Tower DarkPhoenix
	{
		private get { } //Length: 308
	}

	public PhoenixRebirth() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private Tower get_DarkPhoenix() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	private void Process(int elapsed) { }

	private void SpawnZombieZOMGs(int manaConsumed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

