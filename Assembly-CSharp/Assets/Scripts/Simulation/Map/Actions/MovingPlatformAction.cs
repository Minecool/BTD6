namespace Assets.Scripts.Simulation.Map.Actions;

public class MovingPlatformAction : MapAction
{
	public MovingPlatformActionModel mpModel; //Field offset: 0x60
	private bool processMovement; //Field offset: 0x68
	private Area[] areasToMove; //Field offset: 0x70
	private int triggerCount; //Field offset: 0x78
	private PlayableGraph playableGraph; //Field offset: 0x80
	private AnimationClipPlayable playableClip; //Field offset: 0x90
	private double currentTime; //Field offset: 0xA0
	private double destinationTime; //Field offset: 0xA8
	private bool needToUpdateThrowCache; //Field offset: 0xB0

	public MovingPlatformAction() { }

	public virtual void DeInit() { }

	public virtual void GotoPostAction(int triggerCount, bool loadSave) { }

	public virtual void GotoPreAction() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void MoveSimAreas(float ft, float tt, bool moveTowers) { }

	public virtual void PerformAction() { }

	private void Process(int elaspedTime) { }

}

