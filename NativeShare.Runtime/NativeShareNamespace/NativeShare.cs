namespace NativeShareNamespace;

public static class NativeShare
{
	internal sealed class ShareResultCallback : MulticastDelegate
	{

		public ShareResultCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ShareResult result, string shareTarget, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ShareResult result, string shareTarget) { }

	}


}

