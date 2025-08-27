namespace Assets.Scripts.Simulation.Objects;

public interface IMutable : IRootBehavior, IRootObject
{

	public void AddMutator(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, bool cascadeMutators = false, bool includeSubTowers = false, bool ignoreRecursionCheck = false, int roundsRemaining = -1, bool isParagonMutator = false, bool cantBeAbsorbed = false) { }

	public void CopyMutatorsFrom(Mutable from) { }

	public bool FilterMutation(BehaviorMutator mutator, ICollection<BehaviorMutatorFilter> _) { }

	public BehaviorMutator GetMutator(string id) { }

	public TimedMutator GetMutatorById(string id) { }

	public BehaviorMutator GetMutatorByKey(string key) { }

	public IList<TimedMutator> GetMutators() { }

	public void GetMutatorsById(string id, List<TimedMutator> matchingMutators) { }

	public void GetMutatorsByKey(string key, List<BehaviorMutator> mutatorsToGet) { }

	public void GetMutatorsByKey(string key, List<TimedMutator> matchingMutators) { }

	public TimedMutator GetTimedMutator(string id) { }

	public bool HasMutator(BehaviorMutator mutator) { }

	public bool HasMutatorActive(BehaviorMutator mutator) { }

	public bool IsMutatedBy(BehaviorMutator mutator) { }

	public bool IsMutatedBy(string id) { }

	public bool IsMutatedBy(Type behaviorClass) { }

	public void RemoveExpiredMutators(bool roundTimeElapsedChanged) { }

	public bool RemoveMutator(BehaviorMutator mutator) { }

	public void RemoveMutatorsById(string id) { }

	public void RemoveMutatorsByKey(string key) { }

	public void RemoveMutatorsByKeys(String[] keys) { }

	public void UpdateRootModel(Model model) { }

	public void UpdateRoundMutators() { }

}

