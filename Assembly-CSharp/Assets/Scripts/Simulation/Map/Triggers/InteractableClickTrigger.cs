namespace Assets.Scripts.Simulation.Map.Triggers;

public class InteractableClickTrigger : MapTrigger
{
	private int lastFrameActivated; //Field offset: 0x80
	private InteractableClickTriggerModel icsModel; //Field offset: 0x88

	private bool IsOffCooldown
	{
		private get { } //Length: 73
	}

	public InteractableClickTrigger() { }

	public virtual void DeInit() { }

	private bool get_IsOffCooldown() { }

	public virtual MapEventTriggerSaveData GetSaveData() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnClick(string interactableName) { }

	public virtual void SetSaveData(MapEventTriggerSaveData saveData) { }

}

