namespace Assets.Scripts.GameEditor;

public static class GameEditorHelpers
{
	public const float minScale = 0.2; //Field offset: 0x0
	public const float maxScale = 10; //Field offset: 0x0
	public const float scaleSpeed = 0.1; //Field offset: 0x0

	public static GameEditorData Data
	{
		 get { } //Length: 71
	}

	public static void AdjustScale(RectTransform rectTransform, Vector3 position, float delta) { }

	public static string CapitalizeFirstLetter(string input) { }

	public static Behavior CreateBehaviorFromType(Type type) { }

	public static VariableBaseViewModel FindVariableViewModelForBehaviorViewModel(BehaviorViewModel currentBehaviorViewModel, BehaviorViewModel selectedBehaviorViewModel) { }

	public static GameEditorData get_Data() { }

	public static string GetComponentViewNameFromBehaviorVM(BehaviorViewModel behaviorVM) { }

	public static object GetDefaultValue(Type type) { }

	public static Type GetElementType(Type type) { }

	public static string GetFormattedName(string toFormat, string textToRemove) { }

	public static Type GetTypeFromModelType(string modelType) { }

	public static Array InsertIntoArray(Array originalArray, object newItem) { }

	public static bool IsDefaultValue(object value, ParameterInfo parameterInfo) { }

	public static bool IsVariableListPrefab(string prefabName) { }

	public static Array RemoveFromArray(Array originalArray, object itemToRemove) { }

	public static void SetPivotAndScale(RectTransform rectTransform, Vector2 localPoint, float delta) { }

	public static string ToTitleCaseWithSpaces(string input) { }

}

