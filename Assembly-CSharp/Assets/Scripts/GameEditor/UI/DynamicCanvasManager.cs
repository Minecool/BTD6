namespace Assets.Scripts.GameEditor.UI;

public class DynamicCanvasManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Type, Boolean> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetModelTypesWithCanvasAttribute>b__10_0(Type t) { }

	}

	public static DynamicCanvasManager instance; //Field offset: 0x0
	public GameObject canvasViewPrefab; //Field offset: 0x20
	public Transform canvasContainerTransform; //Field offset: 0x28
	private Camera editorCamera; //Field offset: 0x30
	private readonly Dictionary<Type, CanvasViewBase> canvasInstances; //Field offset: 0x38
	private bool showing; //Field offset: 0x40
	private bool setup; //Field offset: 0x41

	public DynamicCanvasManager() { }

	public void Awake() { }

	private void CreateCanvasesForFlaggedModels() { }

	private void CreateCanvasForModel(Type modelType) { }

	private CanvasViewBase CreateGraphViewForModel() { }

	private IEnumerable<Type> GetModelTypesWithCanvasAttribute() { }

	private void SetupCanvasManager() { }

	public void ToggleGameEditorCanvas() { }

}

