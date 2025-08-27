namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public interface ITowerPurchaseButton : ILockable, IDraggable, IHighlightable, IDisablable
{

	public GameObject GameObject
	{
		 get { } //Length: 0
	}

	public bool IsHero
	{
		 get { } //Length: 0
	}

	public TowerModel TowerModel
	{
		 get { } //Length: 0
	}

	public Transform Transform
	{
		 get { } //Length: 0
	}

	public void ButtonActivated(bool isFromHotkey = false) { }

	public void CashChanged() { }

	public void GameRestarted() { }

	public GameObject get_GameObject() { }

	public bool get_IsHero() { }

	public TowerModel get_TowerModel() { }

	public Transform get_Transform() { }

	public string GetBaseId() { }

	public void ItemCreated() { }

	public void ItemDestroyed() { }

	public void RoundEnd() { }

	public void SetDirty() { }

	public void UnlocksChanged() { }

	public void UpdateDisplay(bool canPlayMonkeyTeamBrokenAnim = false) { }

	public void UpgradesChanged() { }

	public void XpChanged() { }

}

