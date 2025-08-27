namespace Assets.Scripts.Unity.UI_New.InGame;

public class InGameListeners
{
	internal sealed class InGameOnLoseLevelDelegate : MulticastDelegate
	{

		public InGameOnLoseLevelDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class InGameTutorialRoundEnd : MulticastDelegate
	{

		public InGameTutorialRoundEnd(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int round, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int round) { }

	}

	internal sealed class UpgradeScreenPurchasedUpgradeDelegate : MulticastDelegate
	{

		public UpgradeScreenPurchasedUpgradeDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(UpgradeModel upgradeModel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(UpgradeModel upgradeModel) { }

	}

	public static InGameListeners instance; //Field offset: 0x0
	public UpgradeScreenPurchasedUpgradeDelegate UpgradeScreenOnPurchasedUpgrade; //Field offset: 0x10
	[CompilerGenerated]
	private InGameOnLoseLevelDelegate InGameOnLoseLevel; //Field offset: 0x18
	[CompilerGenerated]
	private InGameTutorialRoundEnd InGameOnTutorialRoundEnd; //Field offset: 0x20

	public event InGameOnLoseLevelDelegate InGameOnLoseLevel
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event InGameTutorialRoundEnd InGameOnTutorialRoundEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public InGameListeners() { }

	[CompilerGenerated]
	public void add_InGameOnLoseLevel(InGameOnLoseLevelDelegate value) { }

	[CompilerGenerated]
	public void add_InGameOnTutorialRoundEnd(InGameTutorialRoundEnd value) { }

	public void ClearUiListeners() { }

	public void Destroy() { }

	public void InvokeInGameOnLoseLevel() { }

	public void InvokeInGameOnTutorialRoundEnd(int data) { }

	[CompilerGenerated]
	public void remove_InGameOnLoseLevel(InGameOnLoseLevelDelegate value) { }

	[CompilerGenerated]
	public void remove_InGameOnTutorialRoundEnd(InGameTutorialRoundEnd value) { }

}

