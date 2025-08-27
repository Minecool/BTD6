namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(ToggleAbilityCooldownOnTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ToggleAbilityCooldownOnTriggerModel : SimulationBehaviorModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<String> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__4_0(string x) { }

	}

	public string triggerId; //Field offset: 0x30
	public String[] abilityIds; //Field offset: 0x38
	public bool unpauseAtRoundEnd; //Field offset: 0x40
	public bool AllAbilities; //Field offset: 0x41

	public ToggleAbilityCooldownOnTriggerModel(string triggerId, String[] abilityIds, bool unpauseAtRoundEnd) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

