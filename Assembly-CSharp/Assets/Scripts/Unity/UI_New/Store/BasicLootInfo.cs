namespace Assets.Scripts.Unity.UI_New.Store;

public class BasicLootInfo : MonoBehaviour
{
	public TMP_Text description; //Field offset: 0x20
	public Image icon; //Field offset: 0x28

	public BasicLootInfo() { }

	public void Bind(BaseLoot loot) { }

}

