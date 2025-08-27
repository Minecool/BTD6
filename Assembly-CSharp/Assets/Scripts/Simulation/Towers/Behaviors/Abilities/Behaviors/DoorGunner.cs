namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class DoorGunner : AbilityBehavior
{
	public DoorGunnerModel doorGunnerModel; //Field offset: 0x68
	public Tower targetTower; //Field offset: 0x70
	private HeliMovement heliMovement; //Field offset: 0x78
	private AirUnit airUnit; //Field offset: 0x80
	private bool isMovingToTower; //Field offset: 0x88
	public bool hasPickedUpTower; //Field offset: 0x89
	private List<Ability> pausedAbilities; //Field offset: 0x90
	private CustomInputData rData; //Field offset: 0x98

	public DoorGunner() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual bool CanUseAbility() { }

	private void DisableTower() { }

	private void EnableTower() { }

	private void EndPickup() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	private bool IsBanned(Tower tower) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	public void PickupTower(bool playSound) { }

	private void PlayActivateSound() { }

	private void PlayPickUpSound() { }

	private void Process(int elapsed) { }

	public void PutDownTower() { }

	public virtual bool ShowInAbilityMenu() { }

	private void StartMovingToTower(bool playSound) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

