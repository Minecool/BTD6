namespace Assets.Scripts.Unity.UI_New.TrophyStore;

public class TrophyStoreFilterButton : MonoBehaviour
{
	public TrophyStoreFilter tab; //Field offset: 0x20
	public TrophyItemSubFilter subFilter; //Field offset: 0x24
	public Toggle toggle; //Field offset: 0x28

	public TrophyStoreFilterButton() { }

	public string GetLocalizedSubFilter() { }

	public string GetLocalizedTabFilter() { }

}

