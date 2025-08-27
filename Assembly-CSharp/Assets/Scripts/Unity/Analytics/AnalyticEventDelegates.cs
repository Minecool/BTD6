namespace Assets.Scripts.Unity.Analytics;

public static class AnalyticEventDelegates
{
	internal sealed class TutorialCompleted : MulticastDelegate
	{

		public TutorialCompleted(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool isVictory, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool isVictory) { }

	}


}

