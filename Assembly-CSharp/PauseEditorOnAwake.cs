//Type is in global namespace

public class PauseEditorOnAwake : MonoBehaviour
{
	public bool pauseOnAwake; //Field offset: 0x20
	public bool pauseOnStart; //Field offset: 0x21
	public bool pauseOnEnable; //Field offset: 0x22
	public bool pauseOnDisable; //Field offset: 0x23

	public PauseEditorOnAwake() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

