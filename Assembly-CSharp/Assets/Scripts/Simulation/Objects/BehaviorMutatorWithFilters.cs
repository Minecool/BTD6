namespace Assets.Scripts.Simulation.Objects;

public class BehaviorMutatorWithFilters : BehaviorMutator
{
	public List<BehaviorMutatorFilter> filters; //Field offset: 0x70

	protected BehaviorMutatorWithFilters(string id, bool isUnique = true, int priority = 1, bool lastAppliesFirst = false, BuffIndicatorModel buffIndicator = null, int stackCount = 0) { }

}

