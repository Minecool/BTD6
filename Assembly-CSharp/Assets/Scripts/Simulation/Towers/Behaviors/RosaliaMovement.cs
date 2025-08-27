namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RosaliaMovement : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Bloon, Single> <>9__29_0; //Field offset: 0x8
		public static Func<Bloon, Single> <>9__29_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <GetBloonTarget>b__29_0(Bloon possibleTarget) { }

		internal float <GetBloonTarget>b__29_1(Bloon possibleTarget) { }

	}

	[CompilerGenerated]
	private sealed class <GetAdditionalDisplayMeshes>d__50 : IEnumerable<Mesh>, IEnumerable, IEnumerator<Mesh>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Mesh <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private bool isFromHover; //Field offset: 0x24
		public bool <>3__isFromHover; //Field offset: 0x25
		public RosaliaMovement <>4__this; //Field offset: 0x28
		private TowerModel towerModel; //Field offset: 0x30
		public TowerModel <>3__towerModel; //Field offset: 0x38

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
		public <GetAdditionalDisplayMeshes>d__50(int <>1__state) { }

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

	private enum JumpState
	{
		NOT_JUMPING = 0,
		FLYING_UP = 1,
		RELOCATING = 2,
		FLYING_DOWN = 3,
	}

	public RosaliaMovementModel rosaliaMovementModel; //Field offset: 0x68
	private TransformBehavior airUnitTransformBehavior; //Field offset: 0x70
	private Vector2 currentVelocity; //Field offset: 0x78
	private Vector2 groupOffset; //Field offset: 0x80
	private Nullable<Vector2> lastDestination; //Field offset: 0x88
	private bool recalculateGroupOffset; //Field offset: 0x94
	private bool isPursuitEnabled; //Field offset: 0x95
	private Attack airUnitAttack; //Field offset: 0x98
	private Tower placeholderTower; //Field offset: 0xA0
	private AirUnit airUnit; //Field offset: 0xA8
	private int jumpStartedAt; //Field offset: 0xB0
	private int jumpStateLastUpdatedAt; //Field offset: 0xB4
	private JumpState currentJumpState; //Field offset: 0xB8
	private Nullable<Vector2> currentJumpDestination; //Field offset: 0xBC
	private List<Attack> pausedAttacks; //Field offset: 0xC8
	private SwapProjectile swapProjectile; //Field offset: 0xD0
	protected TSMInfoModel newInfo; //Field offset: 0xD8

	private float GetAirUnitAttackRange
	{
		private get { } //Length: 115
	}

	public RosaliaMovement() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	private void ApplyMovement(Bloon bloonTarget, Vector2 destinationPosition2d, float delta) { }

	private void CheckLandedArea() { }

	private TowerModel CreateFakeTower() { }

	private void EndJump() { }

	private float get_GetAirUnitAttackRange() { }

	[IteratorStateMachine(typeof(<GetAdditionalDisplayMeshes>d__50))]
	public virtual IEnumerable<Mesh> GetAdditionalDisplayMeshes(TowerModel towerModel, Vector3 position, bool isFromHover) { }

	private Bloon GetBloonTarget() { }

	private Vector2 GetCappedVelocity(float velocityCapScale) { }

	private float GetHeight() { }

	public Vector2 GetPosition() { }

	public Vector2 GetPursuitDestination(Bloon currentTarget, out bool applyGroupingOffset) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual string GetTowerBehaviorCustomInputClass(string buttonId) { }

	public virtual object GetTowerBehaviorCustomInputData(string buttonId) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBloonValid(Bloon bloon) { }

	private bool IsBloonVisible(Bloon bloon) { }

	public bool IsInJump() { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerDestroyed(Tower destroyedTower) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void PauseAttacks() { }

	private void PlaySound() { }

	public void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void StartJump(Vector2 location) { }

	public void TogglePursuit(bool isEnabled) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateJump() { }

	private void UpdateMovement() { }

	private void UpdatePrefabDisplay() { }

	private void UpdateRotation(Vector2 directionToTarget, TransformBehavior currentTransform) { }

	private void UpdateTilt() { }

}

