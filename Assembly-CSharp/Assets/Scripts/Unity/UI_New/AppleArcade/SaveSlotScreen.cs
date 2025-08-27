namespace Assets.Scripts.Unity.UI_New.AppleArcade;

public class SaveSlotScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public int slotIdx; //Field offset: 0x10
		public SaveSlot saveSlot; //Field offset: 0x18
		public SaveSlotScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <Open>b__0() { }

		internal void <Open>b__1() { }

		internal void <Open>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public int slotIdx; //Field offset: 0x10
		public SaveSlotScreen <>4__this; //Field offset: 0x18
		public SaveSlot saveSlot; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal void <DeleteSlot>g___deleteSlot|0() { }

	}

	[SerializeField]
	private Transform slotContainer; //Field offset: 0x48
	[SerializeField]
	private GameObject slotPrefab; //Field offset: 0x50

	public SaveSlotScreen() { }

	private void CreateSlot(int slotIdx) { }

	private void DeleteSlot(int slotIdx, SaveSlot saveSlot) { }

	private bool IsSelected(int slotIdx) { }

	public virtual void Open(object menuData) { }

	private ProfileModel ProfileDataForSlot(int slotIdx) { }

	private void SelectSlot(int slotIdx) { }

}

