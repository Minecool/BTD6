namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class ContestedTerritoryWorld : MonoBehaviour
{
	[CompilerGenerated]
	private struct <BuildMap>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryWorld <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Camera cam; //Field offset: 0x20
	public ContestedTerritoryCameraRig camRig; //Field offset: 0x28
	public float mouseWheelSmoothingMul; //Field offset: 0x30
	public float pinchSpeedMultiplier; //Field offset: 0x34
	public float interpolateToTileSpeed; //Field offset: 0x38
	public bool mapScreenIsLoading; //Field offset: 0x3C
	public float groundPlaneHeight; //Field offset: 0x40
	public Action<Int32> OnTileSelected; //Field offset: 0x48
	public Action OnUpdate; //Field offset: 0x50
	private int currSelectedTileId; //Field offset: 0x58
	private float rotation; //Field offset: 0x5C
	public bool inputEnabled; //Field offset: 0x60
	private float clickTimer; //Field offset: 0x64
	private Vector3 touchStart; //Field offset: 0x68
	private float zoomDelta; //Field offset: 0x74
	private float zoomAmount; //Field offset: 0x78
	private bool isOverUI; //Field offset: 0x7C
	private bool wasTwoFinger; //Field offset: 0x7D

	public ContestedTerritoryWorld() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<BuildMap>d__12))]
	public Task BuildMap() { }

	public Vector3 GetTileScreenPosition(int tileId) { }

	public Vector3 GetTileViewportPosition(int tileId) { }

	private Vector3 GetWorldPosition() { }

	public void SelectTile(int tileIndex) { }

	public void TransitionTo(int tileId) { }

	private void Update() { }

}

