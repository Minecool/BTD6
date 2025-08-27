namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Redeploy : AbilityBehavior
{
	public const float interactRangeSquared = 16; //Field offset: 0x0
	public static String[] towerBanList; //Field offset: 0x0
	public static Dictionary<String, Int32[]> upgradeBanList; //Field offset: 0x8
	public static String[] pausableAttackList; //Field offset: 0x10
	public RedeployModel redeployModel; //Field offset: 0x68
	private Tower targetTower; //Field offset: 0x70
	private Tower placeholderTower; //Field offset: 0x78
	private HeliMovement heliMovement; //Field offset: 0x80
	private AirUnit airUnit; //Field offset: 0x88
	private DoorGunner doorGunner; //Field offset: 0x90
	private bool isMovingToTower; //Field offset: 0x98
	private bool isRedeployingTower; //Field offset: 0x99
	private Vector2 redeployStartLoc; //Field offset: 0x9C
	private List<Ability> pausedAbilities; //Field offset: 0xA8
	private List<Attack> pausedAttacks; //Field offset: 0xB0
	private List<Attack> temp; //Field offset: 0xB8
	private CustomInputData rData; //Field offset: 0xC0

	private DoorGunner DoorGunner
	{
		private get { } //Length: 111
	}

	private static Redeploy() { }

	public Redeploy() { }

	public virtual void Activate() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public virtual bool CanUseAbility() { }

	private TowerModel CreateFakeTower() { }

	private void DeployTower() { }

	private void DisableTower() { }

	private void EnableTower() { }

	private void EndRedeploy() { }

	private DoorGunner get_DoorGunner() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	private List<Attack> GetPauseableAttacks() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	private bool IsBanned(Tower tower) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	private void PickupTower(bool playSound) { }

	private void PlayActivateSound() { }

	private void PlayDropOffSound() { }

	private void PlayPickUpSound() { }

	private void Process(int elapsed) { }

	public virtual bool ShowInAbilityMenu() { }

	private void StartRedeploy(Vector2 dp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

