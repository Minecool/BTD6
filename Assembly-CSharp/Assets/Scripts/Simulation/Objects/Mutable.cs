namespace Assets.Scripts.Simulation.Objects;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public abstract class Mutable : RootBehavior
{
	public Model mutatedModel; //Field offset: 0x58
	private readonly SortedListLite<TimedMutator> mutators; //Field offset: 0x60
	public int highestGlueLevel; //Field offset: 0x68
	private bool activeMutation; //Field offset: 0x6C
	public Model rootModel; //Field offset: 0x70
	private int lastRoundTimeElapsed; //Field offset: 0x78
	private bool suppressMutation; //Field offset: 0x7C
	private readonly List<BehaviorMutatorFilter> filters; //Field offset: 0x80
	private List<BehaviorMutator> mutatedWith; //Field offset: 0x88

	protected Mutable() { }

	public override void AddMutator(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, bool cascadeMutators = false, bool includeSubTowers = false, bool ignoreRecursionCheck = false, int roundsRemaining = -1, bool isParagonMutator = false, bool cantBeAbsorbed = false) { }

	private void ApplyMutation() { }

	private void ApplyMutationNonRecursive() { }

	public override void CopyMutatorsFrom(Mutable from) { }

	public override bool FilterMutation(BehaviorMutator mutator, ICollection<BehaviorMutatorFilter> _) { }

	public override BehaviorMutator GetMutator(string id) { }

	public override TimedMutator GetMutatorById(string id) { }

	public override BehaviorMutator GetMutatorByKey(string key) { }

	public override IList<TimedMutator> GetMutators() { }

	public override void GetMutatorsById(string id, List<TimedMutator> matchingMutators) { }

	public override void GetMutatorsByKey(string key, List<TimedMutator> matchingMutators) { }

	public override void GetMutatorsByKey(string key, List<BehaviorMutator> mutatorsToGet) { }

	public override TimedMutator GetTimedMutator(string id) { }

	public TimedMutator GetTimedMutatorByKey(string key) { }

	public override bool HasMutator(BehaviorMutator mutator) { }

	public override bool HasMutatorActive(BehaviorMutator mutator) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsMutatedBy(Type behaviorClass) { }

	public override bool IsMutatedBy(BehaviorMutator mutator) { }

	public override bool IsMutatedBy(string id) { }

	protected virtual void OnDestroy() { }

	public void ProcessMute(int elapsed) { }

	protected override void RemovedMutator(BehaviorMutator mutator) { }

	public override void RemoveExpiredMutators(bool roundTimeElapsedChanged) { }

	public override bool RemoveMutator(BehaviorMutator mutator) { }

	protected void RemoveMutatorByIndex(int index) { }

	public override void RemoveMutatorsById(string id) { }

	public override void RemoveMutatorsByKey(string key) { }

	public override void RemoveMutatorsByKeys(String[] keys) { }

	private static int SortMutators(TimedMutator a, TimedMutator b) { }

	public void SuppressMutation(bool suppress) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateModelIfDifferent(Model model) { }

	public override void UpdateRootModel(Model model) { }

	public override void UpdateRoundMutators() { }

}

