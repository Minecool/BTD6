namespace Assets.Scripts.Unity.UI_New.GameOver;

public class CheckpointDefeatScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public CheckpointDefeatScreen <>4__this; //Field offset: 0x10
		public MapSaveDataModel saveData; //Field offset: 0x18
		public KonFuze mmCost; //Field offset: 0x20

		public <>c__DisplayClass14_0() { }

		internal void <ContinueFromCheckpointClicked>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public CheckpointDefeatScreen <>4__this; //Field offset: 0x10
		public MapSaveDataModel mapSave; //Field offset: 0x18
		public KonFuze mmCost; //Field offset: 0x20

		public <>c__DisplayClass15_0() { }

		internal void <RetryLastRoundClicked>b__0() { }

	}

	public Button continueButton; //Field offset: 0x110
	public TMP_Text continueCostTxt; //Field offset: 0x118
	public TMP_Text continueDescTxt; //Field offset: 0x120
	public Button retryButton; //Field offset: 0x128
	public TMP_Text retryCostTxt; //Field offset: 0x130
	public TMP_Text retryDescTxt; //Field offset: 0x138
	protected bool canContinue; //Field offset: 0x140
	protected bool canRetry; //Field offset: 0x141
	protected MapSaveDataModel continueMapSave; //Field offset: 0x148
	protected MapSaveDataModel retryMapSave; //Field offset: 0x150

	protected override bool CanPlayAgain
	{
		 get { } //Length: 3
	}

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	public CheckpointDefeatScreen() { }

	[CompilerGenerated]
	private void <ShowPayToContinuePopup>b__18_0() { }

	[CompilerGenerated]
	private void <ShowPayToContinuePopup>b__18_1() { }

	[CompilerGenerated]
	private void <ShowPayToContinuePopup>b__18_2() { }

	[CompilerGenerated]
	private void <ShowPayToContinuePopup>b__18_3() { }

	protected void ContinueFromCheckpointClicked(MapSaveDataModel saveData, KonFuze mmCost) { }

	protected override bool get_CanPlayAgain() { }

	protected virtual bool get_IsVictoryScreen() { }

	protected KonFuze GetContinueMmCost() { }

	protected KonFuze GetRetryMmCost(IReadOnlyCollection<Int32> checkpointRounds, Int32[] checkpointCosts) { }

	protected void RetryLastRoundClicked(MapSaveDataModel mapSave, KonFuze mmCost) { }

	private void ShowPayToContinuePopup(string title, string body, KonFuze mmCost, ReturnCallback onPaymentAccepted) { }

}

