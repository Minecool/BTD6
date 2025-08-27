namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(BeastHandlerLeash), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BeastHandlerLeashModel : TowerBehaviorModel
{
	[CompilerGenerated]
	private sealed class <GetAdditionalDisplayMeshes>d__29 : IEnumerable<Mesh>, IEnumerable, IEnumerator<Mesh>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Mesh <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private TowerModel towerModel; //Field offset: 0x28
		public TowerModel <>3__towerModel; //Field offset: 0x30
		private Simulation sim; //Field offset: 0x38
		public Simulation <>3__sim; //Field offset: 0x40
		private Vector3 position; //Field offset: 0x48
		public Vector3 <>3__position; //Field offset: 0x54

		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetAdditionalDisplayMeshes>d__29(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Mesh> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Display.Mesh>.GetEnumerator() { }

		[DebuggerHidden]
		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetPetTowerModels>d__35 : IEnumerable<TowerModel>, IEnumerable, IEnumerator<TowerModel>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TowerModel <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public BeastHandlerLeashModel <>4__this; //Field offset: 0x28

		private override TowerModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Towers.TowerModel>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetPetTowerModels>d__35(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<TowerModel> System.Collections.Generic.IEnumerable<Assets.Scripts.Models.Towers.TowerModel>.GetEnumerator() { }

		[DebuggerHidden]
		private override TowerModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Towers.TowerModel>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class ContributionMutator : BehaviorMutator
	{
		public BeastHandlerLeashModel beastHandlerLeashModel; //Field offset: 0x70
		public string towerBaseId; //Field offset: 0x78
		public int power; //Field offset: 0x80

		public ContributionMutator(string mutatorId, string towerBaseId, BeastHandlerLeashModel beastHandlerLeashModel, int power) { }

		public virtual bool CountBuffTowardsAchievement() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

		public virtual int StackCount() { }

	}

	public const string ContributionMutatorIdBase = "BeastHandlerContribution"; //Field offset: 0x0
	public static readonly String[] beastTowerTypeByPath; //Field offset: 0x0
	public TowerModel towerModel; //Field offset: 0x30
	public AttackModel spawnerAttackModel; //Field offset: 0x38
	public TowerModel towerModelSecond; //Field offset: 0x40
	public AttackModel spawnerAttackModelSecond; //Field offset: 0x48
	public int moveAnimationState; //Field offset: 0x50
	public bool rotateToLeashedTower; //Field offset: 0x54
	public PrefabReference contributedToLineDisplayPath; //Field offset: 0x58
	public PrefabReference contributedFromLineDisplayPath; //Field offset: 0x60
	public float contributionDotOffset; //Field offset: 0x68
	public float contributionDotSpacing; //Field offset: 0x6C
	public float contributionDotSpeed; //Field offset: 0x70
	public PrefabReference buffedTextDisplayPrefab; //Field offset: 0x78
	public PrefabReference mergedTextDisplayPrefab; //Field offset: 0x80
	public PrefabReference powerTextDisplayPrefab; //Field offset: 0x88
	public PrefabReference validMergeTargetObjectPath; //Field offset: 0x90
	public BeastHandlerPetModel piranhaPetModel; //Field offset: 0x98
	public BeastHandlerPetModel microraptorPetModel; //Field offset: 0xA0
	public BeastHandlerPetModel gyrfalconPetModel; //Field offset: 0xA8
	public SoundModel mergeSound; //Field offset: 0xB0
	private BuffIndicatorModel buffIndicatorPiranha; //Field offset: 0xB8
	private BuffIndicatorModel buffIndicatorMicroraptor; //Field offset: 0xC0
	private BuffIndicatorModel buffIndicatorGyrfalcon; //Field offset: 0xC8
	public readonly Dictionary<Int32, ContributionMutator> mutatorsOfStackCount; //Field offset: 0xD0

	private static BeastHandlerLeashModel() { }

	public BeastHandlerLeashModel(string name, TowerModel towerModel, AttackModel spawnerAttackModel, TowerModel towerModelSecond, AttackModel spawnerAttackModelSecond, int moveAnimationState, bool rotateToLeashedTower, PrefabReference contributedToLineDisplayPath, PrefabReference contributedFromLineDisplayPath, float contributionDotOffset, float contributionDotSpacing, float contributionDotSpeed, PrefabReference buffedTextDisplayPrefab, PrefabReference mergedTextDisplayPrefab, PrefabReference powerTextDisplayPrefab, PrefabReference validMergeTargetObjectPath, BeastHandlerPetModel piranhaPetModel, BeastHandlerPetModel microraptorPetModel, BeastHandlerPetModel gyrfalconPetModel, SoundModel mergeSound) { }

	public virtual Model Clone() { }

	[IteratorStateMachine(typeof(<GetAdditionalDisplayMeshes>d__29))]
	public virtual IEnumerable<Mesh> GetAdditionalDisplayMeshes(Simulation sim, TowerModel towerModel, Vector3 position, bool isFromHover) { }

	public BuffIndicatorModel GetBuffIndicatorModel(string towerBaseId) { }

	public int GetContributionCountMaxForBeast(string towerBaseId) { }

	public ContributionMutator GetContributionMutator(string beastBaseId, int stackCount) { }

	public static float GetHandlerRange(TowerModel handlerTowerModel) { }

	public bool GetIsContributionEnabledForBeast(string towerBaseId) { }

	public BeastHandlerPetModel GetMatchingPetModel(string towerBaseId) { }

	public TowerModel GetMatchingPetTowerModel(string towerBaseId) { }

	[IteratorStateMachine(typeof(<GetPetTowerModels>d__35))]
	public IEnumerable<TowerModel> GetPetTowerModels() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

