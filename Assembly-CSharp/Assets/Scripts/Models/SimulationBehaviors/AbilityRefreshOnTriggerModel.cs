namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(AbilityRefreshOnTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AbilityRefreshOnTriggerModel : SimulationBehaviorModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<String> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__3_0(string x) { }

	}

	public string triggerId; //Field offset: 0x30
	public String[] abilityIds; //Field offset: 0x38
	public bool AllAbilities; //Field offset: 0x40

	public AbilityRefreshOnTriggerModel(string triggerId, String[] abilityIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

