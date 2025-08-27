namespace Assets.Scripts.Unity.UI_New.Main.WorldItems;

public class OpenGiftbox : InteractableObject
{
	public GameObject container; //Field offset: 0x20
	public AudioClip openChestSound; //Field offset: 0x28
	public AudioClip clickSound; //Field offset: 0x30
	public GameObject dialogObject; //Field offset: 0x38
	public TMP_Text dialogText; //Field offset: 0x40
	private Animator animator; //Field offset: 0x48

	public OpenGiftbox() { }

	private void Awake() { }

	public virtual bool IsInteractable() { }

	private void OnEnable() { }

	public virtual void OnInteract() { }

	private void ShowDialog(string msg) { }

	private void Update() { }

	public void UpdateGiftboxState() { }

}

