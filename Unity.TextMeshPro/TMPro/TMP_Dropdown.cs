namespace TMPro;

[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
[RequireComponent(typeof(RectTransform))]
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public Toggle nothingToggle; //Field offset: 0x10
		public Toggle everythingToggle; //Field offset: 0x18
		public TMP_Dropdown <>4__this; //Field offset: 0x20

		public <>c__DisplayClass76_0() { }

		internal void <Show>b__0(bool x) { }

		internal void <Show>b__1(bool x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_1
	{
		public DropdownItem item; //Field offset: 0x10
		public TMP_Dropdown <>4__this; //Field offset: 0x18

		public <>c__DisplayClass76_1() { }

		internal void <Show>b__2(bool x) { }

	}

	[CompilerGenerated]
	private sealed class <DelayedDestroyDropdownList>d__90 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delay; //Field offset: 0x20
		public TMP_Dropdown <>4__this; //Field offset: 0x28

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
		public <DelayedDestroyDropdownList>d__90(int <>1__state) { }

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

	internal class DropdownEvent : UnityEvent<Int32>
	{

		public DropdownEvent() { }

	}

	private class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		[SerializeField]
		private TMP_Text m_Text; //Field offset: 0x20
		[SerializeField]
		private Image m_Image; //Field offset: 0x28
		[SerializeField]
		private RectTransform m_RectTransform; //Field offset: 0x30
		[SerializeField]
		private Toggle m_Toggle; //Field offset: 0x38

		public Image image
		{
			 get { } //Length: 5
			 set { } //Length: 5
		}

		public RectTransform rectTransform
		{
			 get { } //Length: 5
			 set { } //Length: 5
		}

		public TMP_Text text
		{
			 get { } //Length: 5
			 set { } //Length: 5
		}

		public Toggle toggle
		{
			 get { } //Length: 5
			 set { } //Length: 5
		}

		public DropdownItem() { }

		public Image get_image() { }

		public RectTransform get_rectTransform() { }

		public TMP_Text get_text() { }

		public Toggle get_toggle() { }

		public override void OnCancel(BaseEventData eventData) { }

		public override void OnPointerEnter(PointerEventData eventData) { }

		public void set_image(Image value) { }

		public void set_rectTransform(RectTransform value) { }

		public void set_text(TMP_Text value) { }

		public void set_toggle(Toggle value) { }

	}

	internal class OptionData
	{
		[SerializeField]
		private string m_Text; //Field offset: 0x10
		[SerializeField]
		private Sprite m_Image; //Field offset: 0x18
		[SerializeField]
		private Color m_Color; //Field offset: 0x20

		public Color color
		{
			 get { } //Length: 11
			 set { } //Length: 8
		}

		public Sprite image
		{
			 get { } //Length: 5
			 set { } //Length: 5
		}

		public string text
		{
			 get { } //Length: 5
			 set { } //Length: 5
		}

		public OptionData() { }

		public OptionData(string text) { }

		public OptionData(Sprite image) { }

		public OptionData(string text, Sprite image, Color color) { }

		public Color get_color() { }

		public Sprite get_image() { }

		public string get_text() { }

		public void set_color(Color value) { }

		public void set_image(Sprite value) { }

		public void set_text(string value) { }

	}

	internal class OptionDataList
	{
		[SerializeField]
		private List<OptionData> m_Options; //Field offset: 0x10

		public List<OptionData> options
		{
			 get { } //Length: 5
			 set { } //Length: 5
		}

		public OptionDataList() { }

		public List<OptionData> get_options() { }

		public void set_options(List<OptionData> value) { }

	}

	private static readonly OptionData k_NothingOption; //Field offset: 0x0
	private static readonly OptionData k_EverythingOption; //Field offset: 0x8
	private static readonly OptionData k_MixedOption; //Field offset: 0x10
	private static OptionData s_NoOptionData; //Field offset: 0x18
	[SerializeField]
	private RectTransform m_Template; //Field offset: 0x100
	[SerializeField]
	private TMP_Text m_CaptionText; //Field offset: 0x108
	[SerializeField]
	private Image m_CaptionImage; //Field offset: 0x110
	[SerializeField]
	private Graphic m_Placeholder; //Field offset: 0x118
	[SerializeField]
	[Space]
	private TMP_Text m_ItemText; //Field offset: 0x120
	[SerializeField]
	private Image m_ItemImage; //Field offset: 0x128
	[SerializeField]
	[Space]
	private int m_Value; //Field offset: 0x130
	[SerializeField]
	private bool m_MultiSelect; //Field offset: 0x134
	[SerializeField]
	[Space]
	private OptionDataList m_Options; //Field offset: 0x138
	[SerializeField]
	[Space]
	private DropdownEvent m_OnValueChanged; //Field offset: 0x140
	[SerializeField]
	private float m_AlphaFadeSpeed; //Field offset: 0x148
	private GameObject m_Dropdown; //Field offset: 0x150
	private GameObject m_Blocker; //Field offset: 0x158
	private List<DropdownItem> m_Items; //Field offset: 0x160
	private TweenRunner<FloatTween> m_AlphaTweenRunner; //Field offset: 0x168
	private bool validTemplate; //Field offset: 0x170
	private Coroutine m_Coroutine; //Field offset: 0x178

	public float alphaFadeSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public Image captionImage
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	public TMP_Text captionText
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	public bool IsExpanded
	{
		 get { } //Length: 83
	}

	public Image itemImage
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	public TMP_Text itemText
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	public bool MultiSelect
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public DropdownEvent onValueChanged
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<OptionData> options
	{
		 get { } //Length: 30
		 set { } //Length: 36
	}

	public Graphic placeholder
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	public RectTransform template
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	public int value
	{
		 get { } //Length: 7
		 set { } //Length: 11
	}

	private static TMP_Dropdown() { }

	protected TMP_Dropdown() { }

	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) { }

	public void AddOptions(List<OptionData> options) { }

	public void AddOptions(List<String> options) { }

	public void AddOptions(List<Sprite> options) { }

	private void AlphaFadeList(float duration, float start, float end) { }

	private void AlphaFadeList(float duration, float alpha) { }

	protected virtual void Awake() { }

	public void ClearOptions() { }

	protected override GameObject CreateBlocker(Canvas rootCanvas) { }

	protected override GameObject CreateDropdownList(GameObject template) { }

	protected override DropdownItem CreateItem(DropdownItem itemTemplate) { }

	[IteratorStateMachine(typeof(<DelayedDestroyDropdownList>d__90))]
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	protected override void DestroyBlocker(GameObject blocker) { }

	protected override void DestroyDropdownList(GameObject dropdownList) { }

	protected override void DestroyItem(DropdownItem item) { }

	private static int EverythingValue(int count) { }

	private static int FirstActiveFlagIndex(int value) { }

	public float get_alphaFadeSpeed() { }

	public Image get_captionImage() { }

	public TMP_Text get_captionText() { }

	public bool get_IsExpanded() { }

	public Image get_itemImage() { }

	public TMP_Text get_itemText() { }

	public bool get_MultiSelect() { }

	public DropdownEvent get_onValueChanged() { }

	public List<OptionData> get_options() { }

	public Graphic get_placeholder() { }

	public RectTransform get_template() { }

	public int get_value() { }

	private static T GetOrAddComponent(GameObject go) { }

	public void Hide() { }

	private void ImmediateDestroyDropdownList() { }

	private static bool IsEverythingValue(int count, int value) { }

	public override void OnCancel(BaseEventData eventData) { }

	protected virtual void OnDisable() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void OnSelectItem(Toggle toggle) { }

	public override void OnSubmit(BaseEventData eventData) { }

	public void RefreshShownValue() { }

	public void set_alphaFadeSpeed(float value) { }

	public void set_captionImage(Image value) { }

	public void set_captionText(TMP_Text value) { }

	public void set_itemImage(Image value) { }

	public void set_itemText(TMP_Text value) { }

	public void set_MultiSelect(bool value) { }

	public void set_onValueChanged(DropdownEvent value) { }

	public void set_options(List<OptionData> value) { }

	public void set_placeholder(Graphic value) { }

	public void set_template(RectTransform value) { }

	public void set_value(int value) { }

	private void SetAlpha(float alpha) { }

	private void SetupTemplate() { }

	private void SetValue(int value, bool sendCallback = true) { }

	public void SetValueWithoutNotify(int input) { }

	public void Show() { }

	protected virtual void Start() { }

}

