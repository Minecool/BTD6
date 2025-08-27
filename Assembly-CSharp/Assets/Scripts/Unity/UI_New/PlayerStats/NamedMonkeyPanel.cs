namespace Assets.Scripts.Unity.UI_New.PlayerStats;

public class NamedMonkeyPanel : MonoBehaviour
{
	internal sealed class SelectHander : MulticastDelegate
	{

		public SelectHander(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NamedMonkeyPanel namedMonkeyPanel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NamedMonkeyPanel namedMonkeyPanel) { }

	}

	[CompilerGenerated]
	private SelectHander OnSelect; //Field offset: 0x20
	public NK_TextMeshProUGUI monkeyName; //Field offset: 0x28
	public GameObject highlight; //Field offset: 0x30
	public Image icon; //Field offset: 0x38
	public string id; //Field offset: 0x40
	public bool isHero; //Field offset: 0x48

	public event SelectHander OnSelect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public NamedMonkeyPanel() { }

	[CompilerGenerated]
	public void add_OnSelect(SelectHander value) { }

	[CompilerGenerated]
	public void remove_OnSelect(SelectHander value) { }

	public void Select() { }

}

