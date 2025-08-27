namespace Assets.Scripts.Unity.UI_New.Popups.Epic;

public class BaseEpicAccountPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__5_0; //Field offset: 0x8
		public static UnityAction <>9__5_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__5_0() { }

		internal void <Awake>b__5_1() { }

	}

	public Button privacyPolicyBtn; //Field offset: 0x20
	public Button termsOfServiceBtn; //Field offset: 0x28
	public GameObject loadingSpinner; //Field offset: 0x30
	public TMP_Text errorLabel; //Field offset: 0x38
	protected EpicAccountPopup popup; //Field offset: 0x40

	public BaseEpicAccountPopup() { }

	protected override void Awake() { }

	protected void SetActiveContent(MonoBehaviour content) { }

	protected void SetErrorMessage(string message) { }

	protected override void SetProcessing(bool processing) { }

}

