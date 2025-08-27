namespace Assets.Scripts.Unity.UI_New.Main.WorldItems;

public class QuestMonkey : InteractableObject
{
	public GameObject dialogueObject; //Field offset: 0x20
	public NK_TextMeshProUGUI dialogueText; //Field offset: 0x28
	public AudioClip clickSound; //Field offset: 0x30

	private QuestTrackerManager QuestTrackerManager
	{
		private get { } //Length: 68
	}

	public QuestMonkey() { }

	private QuestTrackerManager get_QuestTrackerManager() { }

	private void OnEnable() { }

	public virtual void OnInteract() { }

}

