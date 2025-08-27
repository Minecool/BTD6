namespace Assets.Scripts.Unity.UI_New.Store.LootItem;

public class BaseLootItemPanel : MonoBehaviour
{
	public TMP_Text shortDescription; //Field offset: 0x20
	public Image icon; //Field offset: 0x28
	public TMP_Text txtBonus; //Field offset: 0x30
	public GameObject AddOneText; //Field offset: 0x38
	public GameObject limitedTimePanel; //Field offset: 0x40

	public BaseLootItemPanel() { }

	public override void Bind(BaseLoot loot) { }

}

