namespace Assets.Scripts.Unity.UI_New.InGame;

public class MenuThemeManager : MonoBehaviour
{
	internal class ThemeDictionary : SerializableDictionary<String, PrefabReference>
	{

		public ThemeDictionary() { }

	}

	[SerializableDictionary]
	public ThemeDictionary themeReferencesByThemeId; //Field offset: 0x20
	protected DynamicUiObject selectionMenu; //Field offset: 0x28
	protected List<BaseTSMTheme> themes; //Field offset: 0x30
	protected BaseTSMTheme currentTheme; //Field offset: 0x38
	protected Coroutine themeUpdateCoroutine; //Field offset: 0x40
	protected AsyncOperationHandle<GameObject> loadHandle; //Field offset: 0x48

	public BaseTSMTheme CurrentTheme
	{
		 get { } //Length: 5
	}

	public MenuThemeManager() { }

	public bool CanInvokeButtonPress(string buttonId) { }

	public BaseTSMTheme get_CurrentTheme() { }

	public override void InfoChanged(Selectable selectable) { }

	public override void Initialise(DynamicUiObject selectionMenu) { }

	public void InvokeButtonPress(string buttonId) { }

	public override void OnButtonPress(TSMButton button) { }

	protected void SetTheme(BaseTSMTheme newTheme) { }

	protected override string ThemeForEntity(IPlaceableEntity entity) { }

	public override void UpdateFromSimInfo(Selectable selectable, Dictionary<String, TSMInfoModel> objects) { }

	public override void UpdateTheme(Selectable selected) { }

	public override IEnumerator UpdateThemeAsync(Selectable selected) { }

}

