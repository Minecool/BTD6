namespace Assets.Scripts.Simulation.Map.Gizmos;

public class WorkshopReverseMotor : MapGizmoBehavior
{
	private WorkshopReverseMotorModel modl; //Field offset: 0x68
	private int timesActivated; //Field offset: 0x70
	private bool isActive; //Field offset: 0x74
	private int durationFrames; //Field offset: 0x78
	private int activatedUntilFrame; //Field offset: 0x7C
	private float mapBloonSpeedBefore; //Field offset: 0x80

	public WorkshopReverseMotor() { }

	private void Activate(bool isFromSave) { }

	public virtual void Attatched() { }

	private void DeActivate() { }

	public virtual int GetActivateCost() { }

	public virtual string GetDisplayMessage() { }

	public virtual MapGizmoBehaviorSaveData GetSaveData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsInteractable() { }

	public virtual void LoadSaveData(MapGizmoBehaviorSaveData data) { }

	public virtual void OnInteract(int playerIndex) { }

	private void Process(int elasped) { }

	private void UpdateTimeDisplay() { }

}

