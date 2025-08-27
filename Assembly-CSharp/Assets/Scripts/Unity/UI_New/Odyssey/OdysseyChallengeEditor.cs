namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyChallengeEditor : ChallengeEditor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SpecialCondition, String> <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <Initialise>b__24_0(SpecialCondition x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public OdysseyChallengeEditor <>4__this; //Field offset: 0x10
		public DailyChallengeModel cloneDcm; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <ApplyUiSettingsToDCM>b__0() { }

		internal void <ApplyUiSettingsToDCM>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public OdysseyChallengeEditor <>4__this; //Field offset: 0x10
		public Vector2 origScrollRectPlusMaskOffsetMin; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

		internal void <GamepadInit>b__0(InputSystemMode x) { }

		internal void <GamepadInit>b__1(GameObject x) { }

	}

	private sealed class ProfanityFinish : MulticastDelegate
	{

		public ProfanityFinish(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool result) { }

	}

	public Lightbox backgroundBtn; //Field offset: 0x260
	public Button mapMaskBtn; //Field offset: 0x268
	private int index; //Field offset: 0x270
	public TMP_Text roundSetDataTxt; //Field offset: 0x278
	public Button importRoundSetBtn; //Field offset: 0x280
	public Button addRoundSetBtn; //Field offset: 0x288
	public Button removeRoundSetBtn; //Field offset: 0x290
	public TMP_Dropdown importedRoundsetSaveData; //Field offset: 0x298
	public TMP_Dropdown addRoundsetSaveData; //Field offset: 0x2A0
	public GameObject panel_importRoundsetDataContent; //Field offset: 0x2A8
	public TMP_InputField panel_roundSetJsonData; //Field offset: 0x2B0
	public TMP_InputField panel_roundSetNameData; //Field offset: 0x2B8
	public TMP_Dropdown panel_roundsetSaveData; //Field offset: 0x2C0
	public Button panel_addRoundSetBtn; //Field offset: 0x2C8
	public Button panel_removeRoundSetBtn; //Field offset: 0x2D0
	public Lightbox panel_backgroundBackBtn; //Field offset: 0x2D8
	private bool listenersEnabled; //Field offset: 0x2E0
	private ILocProvider locs; //Field offset: 0x2E8
	private OdysseyEditor odysseyEditorScreen; //Field offset: 0x2F0
	private OdysseyEditorMap odysseyEditorMap; //Field offset: 0x2F8
	public RectTransform scrollRectPlusMask; //Field offset: 0x300

	public int ChallengeIndex
	{
		 get { } //Length: 7
	}

	public OdysseyChallengeEditor() { }

	[CompilerGenerated]
	private void <Clear>b__25_0() { }

	protected virtual void ApplyDcmSettingsToUI() { }

	public virtual void ApplyUiSettingsToDCM() { }

	protected virtual void Clear() { }

	private void ClearConfirmed() { }

	public void ConfirmOverwriteData(DailyChallengeModel cloneData) { }

	private void DecJewelBarClicked() { }

	public void GamepadInit() { }

	public int get_ChallengeIndex() { }

	private SliderConfig GetSliderConfig() { }

	private void IncJewelBarClicked() { }

	public void Initialise(OdysseyEditor odysseyEditorScreen, ref DailyChallengeModel dcm, int index, OdysseyEditorMap odysseyEditorMap) { }

	protected virtual bool IsSpecialConditionAutosetOn() { }

	public void MapMaskButtonClicked() { }

	private void OnClickBackground() { }

	private void ResetJewelBarClicked() { }

	public void RevertData() { }

	protected virtual void SetCash(string val) { }

	protected virtual void SetEndRound(string val) { }

	protected virtual void SetRound(string val) { }

	protected virtual void SetSpecialConditionAutosetOn(bool isOn) { }

	protected virtual void UpdateInputFieldVisuals() { }

	public void UpdateMap() { }

	protected virtual void ValidateInputFields() { }

}

