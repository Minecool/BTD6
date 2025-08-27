namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventCardItem : MonoBehaviour
{
	public Button button; //Field offset: 0x20
	public Image image; //Field offset: 0x28
	public TMP_Text towerText; //Field offset: 0x30
	public TMP_Text tierText; //Field offset: 0x38
	public GameObject[] buttonGlows; //Field offset: 0x40

	public CollectionEventCardItem() { }

	public void Awake() { }

}

