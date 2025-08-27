namespace Assets.Scripts.Simulation.Map.Actions;

public class RotateAreaAction : MapAction
{
	public RotateAreaActionModel raaModel; //Field offset: 0x60
	public float rotationPerFrame; //Field offset: 0x68
	public int durationFrames; //Field offset: 0x6C
	private Area areaToRotate; //Field offset: 0x70
	private float currRotation; //Field offset: 0x78
	private List<Int32> spinList; //Field offset: 0x80
	private bool processAddedd; //Field offset: 0x88
	private bool loopIsPlaying; //Field offset: 0x89

	public RotateAreaAction() { }

	public virtual void DeInit() { }

	public virtual void GotoPostAction(int triggerCount, bool loadSave) { }

	public virtual void GotoPreAction() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void KillSoundLoop() { }

	public virtual void PerformAction() { }

	private void Process(int elaspedTime) { }

	private void RotateAreaBy(float rotation, bool rotateTowers) { }

}

