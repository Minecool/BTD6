namespace UnityEngine.UIElements;

public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ContextualMenuPopulateEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DropdownMenu <menu>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventBase <triggerEvent>k__BackingField; //Field offset: 0xA8
	private ContextualMenuManager m_ContextualMenuManager; //Field offset: 0xB0

	public private DropdownMenu menu
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private EventBase triggerEvent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static ContextualMenuPopulateEvent() { }

	public ContextualMenuPopulateEvent() { }

	[CompilerGenerated]
	public DropdownMenu get_menu() { }

	[CompilerGenerated]
	public EventBase get_triggerEvent() { }

	public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected private virtual void PostDispatch(IPanel panel) { }

	[CompilerGenerated]
	private void set_menu(DropdownMenu value) { }

	[CompilerGenerated]
	private void set_triggerEvent(EventBase value) { }

}

