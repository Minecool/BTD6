namespace Assets.Scripts.Unity.UI_New.Store;

public class LootButton : MonoBehaviour
{
	public Transform standardContainer; //Field offset: 0x20
	public TMP_Text quantity; //Field offset: 0x28
	public TMP_Text title; //Field offset: 0x30
	public Image icon; //Field offset: 0x38

	public LootButton() { }

	public void Bind(BaseLoot loot) { }

}

