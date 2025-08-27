namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class ComponentViewModel
{
	internal sealed class OnEntityCreated : MulticastDelegate
	{

		public OnEntityCreated(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnUpdateComponentView : MulticastDelegate
	{

		public OnUpdateComponentView(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	private EntityViewModel <EntityViewModel>k__BackingField; //Field offset: 0x10
	public string ComponentViewName; //Field offset: 0x18

	public private EntityViewModel EntityViewModel
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public ComponentViewModel(EntityViewModel entityViewModel) { }

	[CompilerGenerated]
	public EntityViewModel get_EntityViewModel() { }

	public override void Initialise() { }

	public override void OnDestroy() { }

	[CompilerGenerated]
	private void set_EntityViewModel(EntityViewModel value) { }

}

