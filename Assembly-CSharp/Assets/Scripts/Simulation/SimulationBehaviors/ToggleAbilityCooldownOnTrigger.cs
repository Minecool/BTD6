namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class ToggleAbilityCooldownOnTrigger : SimulationTriggerBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string abilityName; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <ContainsAbilityId>b__0(string x) { }

	}

	private ToggleAbilityCooldownOnTriggerModel behaviorModel; //Field offset: 0x58
	private bool pauseAbility; //Field offset: 0x60
	private bool hasPausedAbilities; //Field offset: 0x61
	private List<Ability> abilities; //Field offset: 0x68
	private int currentRound; //Field offset: 0x70

	public ToggleAbilityCooldownOnTrigger() { }

	private bool ContainsAbilityId(string abilityName) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	public virtual void OnTriggerActivated(String[] triggers, int round = -1) { }

	public virtual void PerformTrigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

