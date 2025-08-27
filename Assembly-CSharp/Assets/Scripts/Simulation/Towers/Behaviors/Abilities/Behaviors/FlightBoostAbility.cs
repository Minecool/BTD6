namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class FlightBoostAbility : AbilityBehavior
{
	public FlightBoostAbilityModel flightBoostAbilityModel; //Field offset: 0x68
	private Entity effectDuringWorkshop; //Field offset: 0x70
	private Entity effectDuringAirUnit; //Field offset: 0x78
	private List<Tower> mutatedTowers; //Field offset: 0x80
	private RosaliaMovement rosaliaMovement; //Field offset: 0x88
	private readonly String[] allowedTowers; //Field offset: 0x90
	private bool wasActive; //Field offset: 0x98
	private AirUnitMutator addedMutator; //Field offset: 0xA0

	public FlightBoostAbility() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private void Deactivate() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	public void OnPostTowerDestroyed(Tower tower) { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

