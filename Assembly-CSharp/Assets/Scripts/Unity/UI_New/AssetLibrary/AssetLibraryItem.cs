namespace Assets.Scripts.Unity.UI_New.AssetLibrary;

[RequireComponent(typeof(Toggle))]
public class AssetLibraryItem : MonoBehaviour
{
	[SerializeField]
	private Image thumbnail; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI id; //Field offset: 0x28
	[CompilerGenerated]
	private Entry<BTD6AssetFlags> <Entry>k__BackingField; //Field offset: 0x30

	public private Entry<BTD6AssetFlags> Entry
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public AssetLibraryItem() { }

	public void Bind(Entry<BTD6AssetFlags> entry) { }

	[CompilerGenerated]
	public Entry<BTD6AssetFlags> get_Entry() { }

	[CompilerGenerated]
	private void set_Entry(Entry<BTD6AssetFlags> value) { }

}

