namespace Assets.Scripts.Unity.UI_New.ContestedTerritory.CameraRig;

public class ContestedTerritoryCameraRig : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <AnimateTile>d__48 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int tileId; //Field offset: 0x20
		public ContestedTerritoryCameraRig <>4__this; //Field offset: 0x28
		public float animationWaitTime; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <AnimateTile>d__48(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <CancelMapRefreshAnimationAsync>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryCameraRig <>4__this; //Field offset: 0x28
		private TaskAwaiter<ContestedTerritoryRefreshResult> <>u__1; //Field offset: 0x30
		private Enumerator<Int32, ContestedTerritoryGameTile> <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <PerformMapRefreshAnimation>d__47 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ContestedTerritoryCameraRig <>4__this; //Field offset: 0x20
		public ContestedTerritoryRefreshResult refreshResult; //Field offset: 0x28
		private IEnumerator<Int32> <>7__wrap1; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <PerformMapRefreshAnimation>d__47(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <PlayInitialLoadAnimationAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryCameraRig <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayInitialLoadAnimationAsync>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryCameraRig <>4__this; //Field offset: 0x28
		public Vector3 startPos; //Field offset: 0x30
		public Vector3 endPos; //Field offset: 0x3C
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static float lastDist; //Field offset: 0x0
	private static Vector3 lastFocus; //Field offset: 0x4
	public Camera cam; //Field offset: 0x20
	public float minHeight; //Field offset: 0x28
	public float maxHeight; //Field offset: 0x2C
	public float maxRadius; //Field offset: 0x30
	public AnimationCurve rotationAtHeight; //Field offset: 0x38
	public AnimationCurve zoomSpeedAtHeight; //Field offset: 0x40
	public float initAnimTime; //Field offset: 0x48
	public float initAnimStartHeight; //Field offset: 0x4C
	public float initAnimEndHeight; //Field offset: 0x50
	public float captureAnimCamHeight; //Field offset: 0x54
	public float captureAnimInitialWaitTime; //Field offset: 0x58
	public float captureAnimTransitionToTileTime; //Field offset: 0x5C
	public float captureAnimWaitAtTileTime; //Field offset: 0x60
	public float captureAnimDelayPopupTime; //Field offset: 0x64
	public Action RefreshAnimFinished; //Field offset: 0x68
	public Action InitialLoadAnimFinished; //Field offset: 0x70
	private float rotationY; //Field offset: 0x78
	private float currDist; //Field offset: 0x7C
	private Vector3 focus; //Field offset: 0x80
	private Vector3 animStartFocus; //Field offset: 0x8C
	private Vector3 animEndFocus; //Field offset: 0x98
	private float animStartDist; //Field offset: 0xA4
	private float animEndDist; //Field offset: 0xA8
	private float animTimer; //Field offset: 0xAC
	private float animDuration; //Field offset: 0xB0
	private float animUsePercent; //Field offset: 0xB4
	private float groundPlaneHeight; //Field offset: 0xB8
	private Coroutine mapRefreshAnimCoroutine; //Field offset: 0xC0

	public ContestedTerritoryCameraRig() { }

	[IteratorStateMachine(typeof(<AnimateTile>d__48))]
	private IEnumerator AnimateTile(int tileId, float animationWaitTime) { }

	[AsyncStateMachine(typeof(<CancelMapRefreshAnimationAsync>d__46))]
	private void CancelMapRefreshAnimationAsync() { }

	public void CancelOtherMovement() { }

	public void ConstrainToWorldLimits() { }

	private void DoAnimation(float deltaTime) { }

	public void FocusOn(Vector3 focusOn, float duration, float usePercent = 0, float setDistance = 0) { }

	private Vector3 GetScreenCenterPosition() { }

	public bool HasOtherMovement() { }

	public void Move(Vector3 direction) { }

	public void MoveCameraToTeamStartTile() { }

	public float NormalizedCamHeight() { }

	private void OnDestroy() { }

	[IteratorStateMachine(typeof(<PerformMapRefreshAnimation>d__47))]
	private IEnumerator PerformMapRefreshAnimation(ContestedTerritoryRefreshResult refreshResult) { }

	[AsyncStateMachine(typeof(<PlayInitialLoadAnimationAsync>d__42))]
	public void PlayInitialLoadAnimationAsync() { }

	[AsyncStateMachine(typeof(<PlayInitialLoadAnimationAsync>d__43))]
	public void PlayInitialLoadAnimationAsync(Vector3 startPos, Vector3 endPos) { }

	public void PlayMapRefreshAnimation(ContestedTerritoryRefreshResult refreshResult) { }

	public void Setup(float groundPlaneHeight) { }

	public void UpdateNow(float deltaTime) { }

	public void Zoom(float zoomAmount) { }

}

