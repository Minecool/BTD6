namespace Assets.Scripts.Unity.UI_New.Popups;

public class HintPanel : MonoBehaviour
{
	public int hintId; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28
	public NK_TextMeshProUGUI text; //Field offset: 0x30
	public Image image; //Field offset: 0x38
	private bool opening; //Field offset: 0x40
	private bool closing; //Field offset: 0x41
	private float closingTimer; //Field offset: 0x44

	public HintPanel() { }

	public void Awake() { }

	public bool IsClosed() { }

	public void PlayClose() { }

	public void SetData(int hintId, string text, SpriteReference spriteRef) { }

	public void Update() { }

}

