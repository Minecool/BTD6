namespace Assets.Scripts.Unity.UI_New.AppleArcade;

public class SaveSlot : MonoBehaviour
{
	private class ProfileData
	{
		public Transform root; //Field offset: 0x10
		public NK_TextMeshProUGUI time; //Field offset: 0x18
		public NK_TextMeshProUGUI monkeyMoney; //Field offset: 0x20
		public NK_TextMeshProUGUI level; //Field offset: 0x28
		public NK_TextMeshProUGUI xpInfo; //Field offset: 0x30
		public Image xpBar; //Field offset: 0x38

		public ProfileData() { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI title; //Field offset: 0x20
	[SerializeField]
	private Button deleteButton; //Field offset: 0x28
	[SerializeField]
	private Button selectButton; //Field offset: 0x30
	[SerializeField]
	private Button createNewButton; //Field offset: 0x38
	[SerializeField]
	private GameObject selected; //Field offset: 0x40
	[SerializeField]
	private ProfileData profileData; //Field offset: 0x48
	[SerializeField]
	private Image regularStar; //Field offset: 0x50
	[SerializeField]
	private Image veteranStar; //Field offset: 0x58
	[CompilerGenerated]
	private UnityAction OnDelete; //Field offset: 0x60
	[CompilerGenerated]
	private UnityAction OnCreate; //Field offset: 0x68
	[CompilerGenerated]
	private UnityAction OnSelect; //Field offset: 0x70

	public event UnityAction OnCreate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UnityAction OnDelete
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UnityAction OnSelect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public SaveSlot() { }

	[CompilerGenerated]
	private void <Refresh>b__18_0() { }

	[CompilerGenerated]
	private void <Refresh>b__18_1() { }

	[CompilerGenerated]
	private void <Refresh>b__18_2() { }

	[CompilerGenerated]
	public void add_OnCreate(UnityAction value) { }

	[CompilerGenerated]
	public void add_OnDelete(UnityAction value) { }

	[CompilerGenerated]
	public void add_OnSelect(UnityAction value) { }

	private void PopulateData(ProfileModel data) { }

	public void Refresh(int slotIdx, ProfileModel data, bool isSelected) { }

	[CompilerGenerated]
	public void remove_OnCreate(UnityAction value) { }

	[CompilerGenerated]
	public void remove_OnDelete(UnityAction value) { }

	[CompilerGenerated]
	public void remove_OnSelect(UnityAction value) { }

}

