namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Deploy : AbilityBehavior
{
	public DeployModel deployModel; //Field offset: 0x68
	private Tower placeholderTower; //Field offset: 0x70
	private HeliMovement heliMovement; //Field offset: 0x78
	private AirUnit airUnit; //Field offset: 0x80
	private DoorGunner doorGunner; //Field offset: 0x88
	private Redeploy redeploy; //Field offset: 0x90
	private bool isDeployingTower; //Field offset: 0x98
	private CustomInputData rData; //Field offset: 0xA0

	private DoorGunner DoorGunner
	{
		private get { } //Length: 623
	}

	public Deploy() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual bool CanUseAbility() { }

	private TowerModel CreateFakeTower() { }

	private void DeployTower() { }

	private void EndDeploy() { }

	private DoorGunner get_DoorGunner() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	private void PlayActivateSound() { }

	private void PlayDropOffSound() { }

	private void Process(int elapsed) { }

	public virtual bool ShowInAbilityMenu() { }

	private void StartDeploy(Vector2 dp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

