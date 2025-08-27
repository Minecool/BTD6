namespace Assets.Scripts.Unity.UI_New.Settings;

public class ScreenSizeDropDownSelection : MonoBehaviour
{
	[SerializeField]
	private ScreenSizeDropDown screenSizeDropDown; //Field offset: 0x20
	[SerializeField]
	private GameObject tickbox; //Field offset: 0x28
	[CompilerGenerated]
	private Resolution <Resolution>k__BackingField; //Field offset: 0x30

	public Resolution Resolution
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public ScreenSizeDropDownSelection() { }

	public void CheckTickbox(bool check) { }

	[CompilerGenerated]
	public Resolution get_Resolution() { }

	public void OnTickboxCheck() { }

	[CompilerGenerated]
	public void set_Resolution(Resolution value) { }

}

