namespace Assets.Scripts.Simulation.Map.Gizmos;

public class DarkDungeonsStatue : MapGizmoBehavior
{
	private DarkDungeonsStatueModel darkDungeonsStatueModel; //Field offset: 0x68
	private float leftActivationTime; //Field offset: 0x70
	private float leftDuration; //Field offset: 0x74
	private float rightActivationTime; //Field offset: 0x78
	private float rightDuration; //Field offset: 0x7C
	private bool isActive; //Field offset: 0x80
	private bool hasBeenActivated; //Field offset: 0x81
	private CreateTowerAction createTowerAction; //Field offset: 0x88

	public DarkDungeonsStatue() { }

	private void Activate() { }

	private bool AreAllFiresActive() { }

	private void DarkDungeonsStatueModel_OnFireActivated(object sender, FireActivatedEventArgs e) { }

	public virtual int GetActivateCost() { }

	public virtual string GetDisplayMessage() { }

	public virtual MapGizmoBehaviorSaveData GetSaveData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsDisabled() { }

	public virtual bool IsInteractable() { }

	public virtual void LoadSaveData(MapGizmoBehaviorSaveData data) { }

	protected virtual void OnDestroy() { }

	public virtual void OnInteract(int playerIndex) { }

}

