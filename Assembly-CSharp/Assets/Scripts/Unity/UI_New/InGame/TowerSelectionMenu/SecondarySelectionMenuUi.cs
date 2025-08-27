namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public abstract class SecondarySelectionMenuUi : MonoBehaviour
{
	public PrefabReference prefabReference; //Field offset: 0x20
	public NK_TextMeshProUGUI title; //Field offset: 0x28
	public NK_TextMeshProUGUI description; //Field offset: 0x30
	protected TowerBasedShopMenuItemUi selectedItem; //Field offset: 0x38

	public abstract Animator Animator
	{
		 get { } //Length: 0
	}

	public abstract bool IgnoreSceneHit
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TowerBasedShopMenuItemUi SelectedItem
	{
		 get { } //Length: 5
	}

	public abstract TowerBasedShopItemModel TowerBasedShopItemModel
	{
		 get { } //Length: 0
	}

	protected SecondarySelectionMenuUi() { }

	public abstract Animator get_Animator() { }

	public abstract bool get_IgnoreSceneHit() { }

	public TowerBasedShopMenuItemUi get_SelectedItem() { }

	public abstract TowerBasedShopItemModel get_TowerBasedShopItemModel() { }

	public override void InvokeButtonPress(string buttonId) { }

	public bool IsSelected(TowerBasedShopMenuItemUi itemToCheck) { }

	public abstract void OnShow() { }

	public override void Select(TowerBasedShopMenuItemUi itemToSelect) { }

	public abstract void set_IgnoreSceneHit(bool value) { }

	protected override void UpdateDescription() { }

	public abstract void UpdateUi() { }

}

