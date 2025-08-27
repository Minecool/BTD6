namespace UnityEngine.UIElements;

public class ListView : BaseListView
{
	internal class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{

		public UxmlTraits() { }

	}

	private Func<VisualElement> m_MakeItem; //Field offset: 0x540
	private Action<VisualElement, Int32> m_BindItem; //Field offset: 0x548
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<VisualElement, Int32> <unbindItem>k__BackingField; //Field offset: 0x550
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<VisualElement> <destroyItem>k__BackingField; //Field offset: 0x558

	public Action<VisualElement, Int32> bindItem
	{
		 get { } //Length: 8
		 set { } //Length: 66
	}

	public Action<VisualElement> destroyItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Func<VisualElement> makeItem
	{
		 get { } //Length: 8
		 set { } //Length: 66
	}

	public Action<VisualElement, Int32> unbindItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ListView() { }

	protected virtual CollectionViewController CreateViewController() { }

	public Action<VisualElement, Int32> get_bindItem() { }

	[CompilerGenerated]
	public Action<VisualElement> get_destroyItem() { }

	public Func<VisualElement> get_makeItem() { }

	[CompilerGenerated]
	public Action<VisualElement, Int32> get_unbindItem() { }

	internal virtual bool HasValidDataAndBindings() { }

	public void set_bindItem(Action<VisualElement, Int32> value) { }

	public void set_makeItem(Func<VisualElement> value) { }

}

