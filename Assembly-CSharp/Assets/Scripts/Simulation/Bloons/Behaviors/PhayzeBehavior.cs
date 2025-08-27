namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class PhayzeBehavior : BloonBehavior
{
	public PhayzeBehaviorModel phayzeBehaviorModel; //Field offset: 0x70
	private TransformBehavior phayzeTransformBehavior; //Field offset: 0x78
	private HealthPercentTrigger healthPercentTrigger; //Field offset: 0x80
	private List<RateSupportMutator> mutators; //Field offset: 0x88
	private List<Tower> towersInRange; //Field offset: 0x90
	private int skulls; //Field offset: 0x98
	private bool wasCamo; //Field offset: 0x9C
	private bool wasRemovingCamoDetection; //Field offset: 0x9D
	private bool initialCamoSet; //Field offset: 0x9E
	private bool isInCamoImmunityPhase; //Field offset: 0x9F

	public PhayzeBehavior() { }

	private void AddSlowDebuff(Tower tower) { }

	public virtual void Attatched() { }

	private float DebuffRange() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnCamoRestored() { }

	private void OnCamoStripped() { }

	protected virtual void OnDestroy() { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	private void Process(int elapsed) { }

	private void RefreshTowerRateDebuff(int debuffLevel) { }

	public void RemoveCamo() { }

	private void RemoveCamoDetectionRemoval() { }

	private void RemoveSlowDebuff(Tower tower) { }

	private void RestoreCamo() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public void TogglePhayzeTimerEffects(bool restore) { }

	private void UpdateCamoDetectionRemoval() { }

	private void UpdateCamoState() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateShieldSpeed() { }

	private void UpdateSkulls() { }

}

