namespace Assets.Scripts.Unity.UI_New.Main.MonkeySelect;

public class NewTowerUnlockPip : MonoBehaviour
{
	[SerializeField]
	private GameObject newPipObj; //Field offset: 0x20
	[SerializeField]
	private TowerSet towerSetFilter; //Field offset: 0x28

	public NewTowerUnlockPip() { }

	private void OnEnable() { }

	public void RefreshPip() { }

}

