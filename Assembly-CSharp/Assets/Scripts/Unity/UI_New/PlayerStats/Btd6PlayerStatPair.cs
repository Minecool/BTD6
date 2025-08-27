namespace Assets.Scripts.Unity.UI_New.PlayerStats;

public class Btd6PlayerStatPair : MonoBehaviour
{
	internal sealed class SelectHander : MulticastDelegate
	{

		public SelectHander(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Btd6PlayerStatPair statPair, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Btd6PlayerStatPair statPair) { }

	}

	[CompilerGenerated]
	private SelectHander OnSelect; //Field offset: 0x20
	[CompilerGenerated]
	private SelectHander OnDeselect; //Field offset: 0x28
	[CompilerGenerated]
	private SelectHander Warn; //Field offset: 0x30
	public NK_TextMeshProUGUI statName; //Field offset: 0x38
	public Image icon; //Field offset: 0x40
	public NK_TextMeshProUGUI statValue; //Field offset: 0x48
	public Button btn; //Field offset: 0x50
	public GameObject tick; //Field offset: 0x58
	public string id; //Field offset: 0x60
	private bool isSelected; //Field offset: 0x68
	private bool selectionBlocked; //Field offset: 0x69
	public bool isLegendsStat; //Field offset: 0x6A
	public string legendKey; //Field offset: 0x70

	public event SelectHander OnDeselect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event SelectHander OnSelect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event SelectHander Warn
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public Btd6PlayerStatPair() { }

	[CompilerGenerated]
	public void add_OnDeselect(SelectHander value) { }

	[CompilerGenerated]
	public void add_OnSelect(SelectHander value) { }

	[CompilerGenerated]
	public void add_Warn(SelectHander value) { }

	private string GetLocalizedText(string locKey) { }

	[CompilerGenerated]
	public void remove_OnDeselect(SelectHander value) { }

	[CompilerGenerated]
	public void remove_OnSelect(SelectHander value) { }

	[CompilerGenerated]
	public void remove_Warn(SelectHander value) { }

	public void Select() { }

	public void SetPrivateStatPair(string name, string value, bool active, bool isLegendsStat = false, string legendKey = "") { }

	public void SetPublicStatPair(string name, string value, bool isLegendsStat = false, string legendKey = "") { }

	public void SetSelectionBlocked(bool blocked) { }

}

