namespace UnityEngine.Purchasing;

internal class UIFakeStore : FakeStore
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ProductDefinition, String> <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <CreateRetrieveProductsQuestion>b__20_0(ProductDefinition pid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Action<Boolean, T> callback; //Field offset: 0x0

		public <>c__DisplayClass10_0`1() { }

		internal void <StartUI>b__0(bool result, int codeValue) { }

	}

	private DialogRequest m_CurrentDialog; //Field offset: 0x70
	private int m_LastSelectedDropdownIndex; //Field offset: 0x78
	private GameObject m_UIFakeStoreWindowObject; //Field offset: 0x80
	private GameObject m_EventSystem; //Field offset: 0x88

	public UIFakeStore() { }

	[CompilerGenerated]
	private void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0() { }

	private void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject) { }

	private void CancelButtonClicked() { }

	private void CloseDialog() { }

	private void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow) { }

	private void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback) { }

	private void CreateEventSystem(Transform rootTransform) { }

	private string CreatePurchaseQuestion(ProductDefinition definition) { }

	private string CreateRetrieveProductsQuestion(ReadOnlyCollection<ProductDefinition> definitions) { }

	private void DropdownValueChanged(int selectedItem) { }

	private void EnsureEventSystemCreated(Transform rootTransform) { }

	private UIFakeStoreWindow GetOrCreateFakeStoreWindow() { }

	private void InstantiateDialog() { }

	public bool IsShowingDialog() { }

	private void OkayButtonClicked() { }

	private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, List<String> options, Action<Boolean, Int32> callback) { }

	protected virtual bool StartUI(object model, DialogType dialogType, Action<Boolean, T> callback) { }

}

