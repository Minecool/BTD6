namespace Assets.Scripts.Simulation.Corvus.Spells.OnEnd;

public class CorvusOnSpellEndEffects : CorvusOnSpellEnd
{
	public CorvusOnSpellEndEffectsModel corvusOnSpellEndEffectsModel; //Field offset: 0x68

	public CorvusOnSpellEndEffects() { }

	private void DoEffects(Tower corvusTower, Tower spiritTower, Tower duplicateSpiritTower) { }

	public virtual void Expired(CorvusInstantSpellModel spellModel, Tower corvusTower, Tower spiritTower, Tower duplicateSpiritTower) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void ToggledOff(CorvusContinuousSpellModel spellModel, Tower corvusTower, Tower spiritTower, Tower duplicateSpiritTower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

