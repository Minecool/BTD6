namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class AbilityRefreshOnTrigger : SimulationTriggerBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string abilityName; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <ContainsAbilityId>b__0(string x) { }

	}

	private AbilityRefreshOnTriggerModel behaviorModel; //Field offset: 0x58

	public AbilityRefreshOnTrigger() { }

	private bool ContainsAbilityId(string abilityName) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTriggerActivated(String[] triggers, int round = -1) { }

	public virtual void PerformTrigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

