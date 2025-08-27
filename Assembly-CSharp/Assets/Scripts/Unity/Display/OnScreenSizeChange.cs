namespace Assets.Scripts.Unity.Display;

public sealed class OnScreenSizeChange : MulticastDelegate
{

	public OnScreenSizeChange(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(int w, int h, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(int w, int h) { }

}

