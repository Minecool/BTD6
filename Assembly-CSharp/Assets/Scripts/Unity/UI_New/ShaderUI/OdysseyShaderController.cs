namespace Assets.Scripts.Unity.UI_New.ShaderUI;

[ExecuteInEditMode]
public class OdysseyShaderController : MonoBehaviour
{
	public string propertyName1; //Field offset: 0x20
	public string propertyName2; //Field offset: 0x28
	public string propertyName3; //Field offset: 0x30
	public float transitionTime; //Field offset: 0x38
	private float startedTransitioningAt; //Field offset: 0x3C
	private bool transitioning; //Field offset: 0x40
	private bool forward; //Field offset: 0x41
	private int propertyIdTransition1; //Field offset: 0x44
	private int propertyIdTransition2; //Field offset: 0x48
	private int propertyIdTransition3; //Field offset: 0x4C
	private int currentActiveShader; //Field offset: 0x50
	private int priorDifficltyState; //Field offset: 0x54
	[Range(0, 1)]
	public float lerp0102; //Field offset: 0x58
	[Range(0, 1)]
	public float lerp0203; //Field offset: 0x5C
	[Range(0, 1)]
	public float lerp0301; //Field offset: 0x60

	public OdysseyShaderController() { }

	private void Awake() { }

	public void GotoPostAction() { }

	public void OnDestroy() { }

	private void OnValidate() { }

	public void PerformAction(int newDifficltyState) { }

	private void RefreshGlobalShaderVariables() { }

	public void SetInitialState(int defaultDifficultyState) { }

	public void SetToOriginalState() { }

	private void Start() { }

	private void Update() { }

}

