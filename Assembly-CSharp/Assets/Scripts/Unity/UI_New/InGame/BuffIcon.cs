namespace Assets.Scripts.Unity.UI_New.InGame;

public class BuffIcon : MonoBehaviour
{
	public GameObject activeObj; //Field offset: 0x20
	public GameObject inactiveObj; //Field offset: 0x28
	public Image activeIcon; //Field offset: 0x30
	public Image inactiveIcon; //Field offset: 0x38
	public NK_TextMeshProUGUI buffMultiplierTxt; //Field offset: 0x40
	public NK_TextMeshProUGUI buffMultiplierMaxReachedTxt; //Field offset: 0x48
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x50
	private bool isActive; //Field offset: 0x58

	public private string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public BuffIcon() { }

	[CompilerGenerated]
	public string get_Name() { }

	public void Hide() { }

	public void Initialise(string name, SpriteReference spriteToSet) { }

	public void ResolveActiveState() { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	private void SetActive(GameObject obj, bool active) { }

	public void Show(BuffQuery buff) { }

}

