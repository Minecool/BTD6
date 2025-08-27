namespace Assets.Scripts.Unity.Display;

public class UnityDisplayNode : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static GameObjectCallback <>9__75_0; //Field offset: 0x8
		public static GameObjectCallback <>9__75_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <set_Hilight>b__75_0(GameObject o) { }

		internal void <set_Hilight>b__75_1(GameObject o) { }

	}

	[CompilerGenerated]
	private sealed class <SwapAnimationsAsync>d__83 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UnityDisplayNode <>4__this; //Field offset: 0x20
		public List<AnimationChange> acs; //Field offset: 0x28

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
		public <SwapAnimationsAsync>d__83(int <>1__state) { }

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

	public const int signedLayerRange = 32767; //Field offset: 0x0
	public const int layerRange = 65534; //Field offset: 0x0
	public PrefabReference cloneOf; //Field offset: 0x20
	public bool isDestroyed; //Field offset: 0x28
	private bool swappingAnimations; //Field offset: 0x29
	private bool initialised; //Field offset: 0x2A
	private Animator animationComponent; //Field offset: 0x30
	private bool animatorHasStateParam; //Field offset: 0x38
	private AnimationController animationController; //Field offset: 0x40
	private MeshFilter meshComponent; //Field offset: 0x48
	private ParticleSystem particles; //Field offset: 0x50
	private Renderer[] genericRenderers; //Field offset: 0x58
	private Int32[] genericRendererLayers; //Field offset: 0x60
	private SpriteRenderer sprite; //Field offset: 0x68
	public SpriteRenderer spriteInChildren; //Field offset: 0x70
	private GameObjectEnabler gameObjectEnabler; //Field offset: 0x78
	private CustomScaleAnimator customScaleAnimator; //Field offset: 0x80
	private ProjectileTrailEffect projectileTrailEffect; //Field offset: 0x88
	private bool playOnMove; //Field offset: 0x90
	private int animationToSet; //Field offset: 0x94
	public Vector3 towerPlacementPreCalcOffset; //Field offset: 0x98
	private float rotation; //Field offset: 0xA4
	private Quaternion rotationQuat; //Field offset: 0xA8
	private bool isSprite; //Field offset: 0xB8
	private Vector3 velocity; //Field offset: 0xBC
	private Nullable<Vector3> simulatedPosition; //Field offset: 0xC8
	public bool forceAnimInteruptThisFrame; //Field offset: 0xD8
	private int animationState; //Field offset: 0xDC
	private bool animationEnabled; //Field offset: 0xE0
	private int sortingOrder; //Field offset: 0xE4
	private Mesh mesh; //Field offset: 0xE8
	private bool isFullscreen; //Field offset: 0xF0
	private bool hilight; //Field offset: 0xF1

	public bool Active
	{
		 get { } //Length: 35
		 set { } //Length: 87
	}

	public bool AnimationEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 300
	}

	public float AnimationSpeed
	{
		 set { } //Length: 202
	}

	public int AnimationState
	{
		 set { } //Length: 366
	}

	public bool Fullscreen
	{
		 set { } //Length: 370
	}

	public bool Hilight
	{
		 get { } //Length: 8
		 set { } //Length: 531
	}

	public bool Initialised
	{
		 get { } //Length: 17
	}

	public bool IsSprite
	{
		 set { } //Length: 214
	}

	public Mesh Mesh
	{
		 get { } //Length: 8
		 set { } //Length: 2009
	}

	public Vector3 Position
	{
		 get { } //Length: 79
	}

	public float Rotation
	{
		 get { } //Length: 9
		 set { } //Length: 370
	}

	public Vector3 Scale
	{
		 get { } //Length: 71
		 set { } //Length: 278
	}

	public int SortingOrder
	{
		 get { } //Length: 7
		 set { } //Length: 213
	}

	public UnityDisplayNode() { }

	public void AttatchToCamera(string layerName) { }

	private void Awake() { }

	public void Create() { }

	public void Destroy() { }

	public void DisableAllGameObjects() { }

	public void EnableGameObjectsWithKeysDisableRest(List<String> enableKeys) { }

	public bool get_Active() { }

	public bool get_AnimationEnabled() { }

	public bool get_Hilight() { }

	public bool get_Initialised() { }

	public Mesh get_Mesh() { }

	public Vector3 get_Position() { }

	public float get_Rotation() { }

	public Vector3 get_Scale() { }

	public int get_SortingOrder() { }

	private bool HasParameter(string name) { }

	private bool HasParameter(int name) { }

	public void Initialize() { }

	internal void RecalculateGenericRenderers() { }

	public void set_Active(bool value) { }

	public void set_AnimationEnabled(bool value) { }

	public void set_AnimationSpeed(float value) { }

	public void set_AnimationState(int value) { }

	public void set_Fullscreen(bool value) { }

	public void set_Hilight(bool value) { }

	public void set_IsSprite(bool value) { }

	public void set_Mesh(Mesh value) { }

	public void set_Rotation(float value) { }

	public void set_Scale(Vector3 value) { }

	public void set_SortingOrder(int value) { }

	public void SetAnimationTriggers(List<String> trigs) { }

	public void SetArmourState(int value) { }

	public void SetPosition(Vector3 value, bool interpolate = false) { }

	public void SetQuaternionRotation(float x, float y, float z, float w) { }

	public void SetShieldOn(bool value) { }

	public void SetShieldState(int value) { }

	public void SetSortingLayer(string layerName) { }

	public void SwapAnimations(List<AnimationChange> acs) { }

	[IteratorStateMachine(typeof(<SwapAnimationsAsync>d__83))]
	public IEnumerator SwapAnimationsAsync(List<AnimationChange> acs) { }

	public void TriggerStates(List<Int32> stateTriggers) { }

}

