namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class MapValidatePopup : MapManagementPopupBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Toggle, Boolean> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_CanUseConfirmButton>b__7_0(Toggle toggle) { }

	}

	private static bool hasApprovedOneMapThisSession; //Field offset: 0x0
	[SerializeField]
	protected Toggle isCoolToggle; //Field offset: 0x58

	private bool CanUseConfirmButton
	{
		private get { } //Length: 247
	}

	public bool IsCoolSelected
	{
		 get { } //Length: 30
	}

	public MapValidatePopup() { }

	private bool get_CanUseConfirmButton() { }

	public bool get_IsCoolSelected() { }

	protected virtual void OnConfirmClickedAsync() { }

	protected virtual void OnEnable() { }

	protected virtual void SetReason(bool isOn, RejectionReason _) { }

}

