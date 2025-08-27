namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueMonkeyMovement : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Init>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMonkeyMovement <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Animator playerObjAnimator; //Field offset: 0x20
	private RogueMap rogueMap; //Field offset: 0x28
	private Vector3 targetPosition; //Field offset: 0x30
	private Nullable<Vector3> targetPositionPrevious; //Field offset: 0x3C
	private Quaternion rotation; //Field offset: 0x4C
	private Nullable<Quaternion> rotationPrevious; //Field offset: 0x5C
	public float movementTime; //Field offset: 0x70
	[SerializeField]
	private float rotationTime; //Field offset: 0x74
	[SerializeField]
	private float animDelay; //Field offset: 0x78
	private float movementTimer; //Field offset: 0x7C
	private bool isMoving; //Field offset: 0x80

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueData RogueData
	{
		private get { } //Length: 71
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueMonkeyMovement() { }

	private void Awake() { }

	private static float EaseInOutCubic(float t) { }

	private LegendsDataModel get_LegendsData() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	[AsyncStateMachine(typeof(<Init>d__20))]
	public Task Init() { }

	public void MoveToTile(RogueTile tile, RogueTile currentPositionTile) { }

	public void SetAnimTrigger(string triggerName) { }

	public void SetRotation(Quaternion rotation) { }

	public void SitAtTile(RogueTile tile, RogueTile currentPositionTile) { }

	public void StartMoving(string animState) { }

	public void StopMoving() { }

	public void ToggleVisibility(bool visible) { }

	public void TurnTowardsCamera() { }

	private void Update() { }

	private void UpdateMovement() { }

	public void WalkToTile(RogueTile tile, RogueTile currentPositionTile) { }

}

