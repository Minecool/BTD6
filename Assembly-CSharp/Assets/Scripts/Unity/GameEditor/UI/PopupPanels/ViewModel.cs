namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public abstract class ViewModel
{
	internal sealed class OnBackClicked : MulticastDelegate
	{

		public OnBackClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnUpdateView : MulticastDelegate
	{

		public OnUpdateView(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}


	protected ViewModel() { }

	public abstract void OnDestroy() { }

}

