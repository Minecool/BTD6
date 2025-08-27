namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public abstract class TowerPurchaseButton : ItemPurchaseButton, ITowerPurchaseButton, ILockable, IDraggable, IHighlightable, IDisablable
{
	[CompilerGenerated]
	private sealed class <WaitForAnimationEnd>d__41 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TowerPurchaseButton <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <WaitForAnimationEnd>d__41(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	protected GameObject upgradeAvailableIcon; //Field offset: 0x60
	[SerializeField]
	private GameObject upgradeParagonAvailableIcon; //Field offset: 0x68
	[SerializeField]
	private Color notEnoughCashTextColor; //Field offset: 0x70
	[SerializeField]
	protected Animator unlockAnimator; //Field offset: 0x80
	[SerializeField]
	protected GameObject countIcon; //Field offset: 0x88
	[SerializeField]
	protected TMP_Text countText; //Field offset: 0x90
	[SerializeField]
	protected TMP_Text costText; //Field offset: 0x98
	private bool initialised; //Field offset: 0xA0
	protected float cost; //Field offset: 0xA4
	private UpgradeModel[] path1Upgrades; //Field offset: 0xA8
	private UpgradeModel[] path2Upgrades; //Field offset: 0xB0
	private UpgradeModel[] path3Upgrades; //Field offset: 0xB8
	private int buttonIndex; //Field offset: 0xC0
	private bool showCount; //Field offset: 0xC4
	private bool upgradesChanged; //Field offset: 0xC5
	private bool unlocksChanged; //Field offset: 0xC6
	private bool xpChanged; //Field offset: 0xC7
	protected bool cashChanged; //Field offset: 0xC8
	protected bool costChanged; //Field offset: 0xC9
	private bool itemCountsChanged; //Field offset: 0xCA
	protected bool isHero; //Field offset: 0xCB
	protected TowerModel towerModel; //Field offset: 0xD0
	protected ShopMenu shopMenu; //Field offset: 0xD8

	public override GameObject GameObject
	{
		 get { } //Length: 95
	}

	public override bool IsHero
	{
		 get { } //Length: 8
	}

	public override TowerModel TowerModel
	{
		 get { } //Length: 8
	}

	public override Transform Transform
	{
		 get { } //Length: 95
	}

	protected TowerPurchaseButton() { }

	public void Bind(RatioObject menu, Model model, bool showCount, int buttonIndex) { }

	public virtual void ButtonActivated(bool isFromHotkey = false) { }

	public override void CashChanged() { }

	private bool CheckAndShowUpgradeIcon(UpgradeModel[] upgrades) { }

	private void CheckUnlockAnimation() { }

	private void CheckUpgrades() { }

	public override void GameRestarted() { }

	public override GameObject get_GameObject() { }

	public override bool get_IsHero() { }

	public override TowerModel get_TowerModel() { }

	public override Transform get_Transform() { }

	public override string GetBaseId() { }

	private TowerPurchaseLockState GetLockedState() { }

	public bool IsButtonShowing(RectTransform scrollTransform) { }

	public override void ItemCreated() { }

	public override void ItemDestroyed() { }

	protected virtual void OnItemClickedEvent() { }

	protected virtual void OnItemDoubleClickedEvent() { }

	private void PopulatePath(TowerModel tower, int pathIndex, UpgradeModel[] pathUpgrades) { }

	public override void RoundEnd() { }

	protected override void SetAvailable() { }

	protected abstract void SetCountIconGrayscale(bool grayScale) { }

	public override void SetDirty() { }

	public virtual void SetLocked() { }

	protected override void SetNotEnoughCash() { }

	protected override void SetUnavailable() { }

	public virtual void StartDragging() { }

	public override void UnlocksChanged() { }

	protected virtual void Update() { }

	protected void UpdateCost() { }

	private void UpdateCounts() { }

	public abstract void UpdateDisplay(bool canPlayMonkeyTeamBrokenAnim = false) { }

	public override void UpgradesChanged() { }

	[IteratorStateMachine(typeof(<WaitForAnimationEnd>d__41))]
	private IEnumerator WaitForAnimationEnd() { }

	public override void XpChanged() { }

}

