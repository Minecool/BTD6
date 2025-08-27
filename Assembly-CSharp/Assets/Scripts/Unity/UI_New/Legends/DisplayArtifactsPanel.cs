namespace Assets.Scripts.Unity.UI_New.Legends;

public class DisplayArtifactsPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ArtifactDataBase, Boolean> <>9__24_0; //Field offset: 0x8
		public static Func<ArtifactLoot, Boolean> <>9__25_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OpenShowAll>b__24_0(ArtifactDataBase x) { }

		internal bool <ResetUIs>b__25_0(ArtifactLoot x) { }

	}

	[CompilerGenerated]
	private sealed class <GetInventoryArtifactData>d__23 : IEnumerable<ArtifactDataBase>, IEnumerable, IEnumerator<ArtifactDataBase>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ArtifactDataBase <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public DisplayArtifactsPanel <>4__this; //Field offset: 0x28
		private bool excludeTokens; //Field offset: 0x30
		public bool <>3__excludeTokens; //Field offset: 0x31
		private Enumerator<ArtifactLoot> <>7__wrap1; //Field offset: 0x38

		private override ArtifactDataBase System.Collections.Generic.IEnumerator<Assets.Scripts.Data.Artifacts.ArtifactDataBase>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetInventoryArtifactData>d__23(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ArtifactDataBase> System.Collections.Generic.IEnumerable<Assets.Scripts.Data.Artifacts.ArtifactDataBase>.GetEnumerator() { }

		[DebuggerHidden]
		private override ArtifactDataBase System.Collections.Generic.IEnumerator<Assets.Scripts.Data.Artifacts.ArtifactDataBase>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private Button closeBtn; //Field offset: 0x20
	[SerializeField]
	private Lightbox bgClose; //Field offset: 0x28
	[SerializeField]
	private Button discardBtn; //Field offset: 0x30
	[SerializeField]
	private GameObject deleteBanner; //Field offset: 0x38
	[SerializeField]
	private GameObject artifactsInventoryContainer; //Field offset: 0x40
	[SerializeField]
	private GameObject artifactDisplayPrefab; //Field offset: 0x48
	private List<RogueArtifactDisplayIcon> activeArtifactIcons; //Field offset: 0x50
	private RogueArtifactDisplayIcon selectedIcon; //Field offset: 0x58
	private OnDeletedCallback deletedCallback; //Field offset: 0x60
	[SerializeField]
	private NK_TextMeshProUGUI artifactCountTxt; //Field offset: 0x68
	[SerializeField]
	private NK_TextMeshProUGUI artifactNameTxt; //Field offset: 0x70
	[SerializeField]
	private NK_TextMeshProUGUI artifactDescTxt; //Field offset: 0x78
	public bool isDeleteMode; //Field offset: 0x80

	private ArtifactsData ArtifactsData
	{
		private get { } //Length: 71
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public DisplayArtifactsPanel() { }

	[CompilerGenerated]
	private bool <DiscardArtifact>b__30_0(ArtifactLoot x) { }

	[CompilerGenerated]
	private bool <OpenShowExtracted>b__21_0(ArtifactDataBase x) { }

	public void ArtifactSelected(RogueArtifactDisplayIcon artifactIcon) { }

	private void Awake() { }

	public void Close() { }

	private void CloseClicked() { }

	private void DiscardArtifact() { }

	private void DiscardClicked() { }

	private ArtifactsData get_ArtifactsData() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	[IteratorStateMachine(typeof(<GetInventoryArtifactData>d__23))]
	private IEnumerable<ArtifactDataBase> GetInventoryArtifactData(bool excludeTokens = false) { }

	public void OpenDelete(OnDeletedCallback deletedCallback = null) { }

	public void OpenShowAll() { }

	public void OpenShowExtracted() { }

	public void OpenShowInventory() { }

	private void PopulateArtifacts(IEnumerable<ArtifactDataBase> artifactsInv) { }

	private void ResetUIs() { }

}

