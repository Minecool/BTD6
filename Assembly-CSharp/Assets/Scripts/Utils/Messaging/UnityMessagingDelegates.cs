namespace Assets.Scripts.Utils.Messaging;

public static class UnityMessagingDelegates
{
	internal sealed class MainMenuEntered : MulticastDelegate
	{

		public MainMenuEntered(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnCloseScene : MulticastDelegate
	{

		public OnCloseScene(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string sceneName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string sceneName) { }

	}

	internal sealed class OnOpenedScene : MulticastDelegate
	{

		public OnOpenedScene(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string sceneName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string sceneName) { }

	}

	internal sealed class OnOpenScene : MulticastDelegate
	{

		public OnOpenScene(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string sceneName, object metadata, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string sceneName, object metadata) { }

	}

	internal sealed class QueueMainMenuPopupsAsync : MulticastDelegate
	{

		public QueueMainMenuPopupsAsync(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}


}

