namespace UnityEngine.UIElements;

public class RadioButtonGroup : BaseField<Int32>, IGroupBox
{
	[CompilerGenerated]
	private sealed class <get_choices>d__17 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public RadioButtonGroup <>4__this; //Field offset: 0x28
		private PooledObject<List`1<RadioButton>> <_>5__1; //Field offset: 0x30
		private List<RadioButton> <radioButtons>5__2; //Field offset: 0x40
		private Enumerator<RadioButton> <>s__3; //Field offset: 0x48
		private RadioButton <button>5__4; //Field offset: 0x60

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <get_choices>d__17(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : BaseFieldTraits<Int32, UxmlIntAttributeDescription>
	{
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0xA0

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId choicesProperty; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x98
	public static readonly string containerUssClassName; //Field offset: 0xA0
	internal static readonly string containerName; //Field offset: 0xA8
	internal static readonly string choicesContainerName; //Field offset: 0xB0
	private VisualElement m_ChoiceRadioButtonContainer; //Field offset: 0x538
	private VisualElement m_ContentContainer; //Field offset: 0x540
	private UQueryBuilder<RadioButton> m_GetAllRadioButtonsQuery; //Field offset: 0x548
	private readonly List<RadioButton> m_RegisteredRadioButtons; //Field offset: 0x578
	private RadioButton m_SelectedRadioButton; //Field offset: 0x580
	private EventCallback<ChangeEvent`1<Boolean>> m_RadioButtonValueChangedCallback; //Field offset: 0x588
	private bool m_UpdatingButtons; //Field offset: 0x590
	private List<String> m_Choices; //Field offset: 0x598

	[CreateProperty]
	public IEnumerable<String> choices
	{
		[IteratorStateMachine(typeof(<get_choices>d__17))]
		 get { } //Length: 101
		 set { } //Length: 332
	}

	internal List<String> choicesList
	{
		internal set { } //Length: 8
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 18
	}

	private static RadioButtonGroup() { }

	public RadioButtonGroup(string label, List<String> radioButtonChoices = null) { }

	public RadioButtonGroup() { }

	[CompilerGenerated]
	private void <ScheduleRadioButtons>b__31_0() { }

	[CompilerGenerated]
	internal static bool <set_choices>g__AreListEqual|18_0(List<String> list1, IEnumerable<String> list2) { }

	[IteratorStateMachine(typeof(<get_choices>d__17))]
	public IEnumerable<String> get_choices() { }

	public virtual VisualElement get_contentContainer() { }

	private void GetAllRadioButtons(List<RadioButton> radioButtons) { }

	private void RadioButtonValueChangedCallback(ChangeEvent<Boolean> evt) { }

	private void RebuildRadioButtonsFromChoices() { }

	private void RegisterRadioButton(RadioButton radioButton) { }

	private void ScheduleRadioButtons() { }

	public void set_choices(IEnumerable<String> value) { }

	internal void set_choicesList(List<String> value) { }

	public virtual void SetValueWithoutNotify(int newValue) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	private void UnregisterRadioButton(RadioButton radioButton) { }

	private void UpdateRadioButtons(bool notify) { }

}

