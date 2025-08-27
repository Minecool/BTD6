namespace Assets.Scripts.Unity.Scenes;

public class LoadingScreen : GenericAnimatedScene
{
	private static readonly int Exit; //Field offset: 0x0
	private static readonly int Enter; //Field offset: 0x4
	[CompilerGenerated]
	private static LoadingScreen <Instance>k__BackingField; //Field offset: 0x8
	[SerializeField]
	private Animator UiAnimator; //Field offset: 0x28
	[SerializeField]
	private GameObject modsDetectedObj; //Field offset: 0x30
	[SerializeField]
	private RuntimeAnimatorController visionOSAnimationSwap; //Field offset: 0x38

	private static LoadingScreen Instance
	{
		[CompilerGenerated]
		private get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	private static LoadingScreen() { }

	public LoadingScreen() { }

	private void Awake() { }

	[CompilerGenerated]
	private static LoadingScreen get_Instance() { }

	private void OnDestroy() { }

	public void PlayEnterAnimation() { }

	public void PlayExitAnimation() { }

	[CompilerGenerated]
	private static void set_Instance(LoadingScreen value) { }

	public static void SetVisible(bool isVisible) { }

	public static void ShowModsDetected() { }

	private void Start() { }

	public virtual IEnumerator StartCloseAnimation() { }

}

