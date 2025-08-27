namespace Assets.Scripts.Models.ContestedTerritory;

public class CtTowerLimitsModModel : MutatorModModel, IModifyContestedTerritoryRules
{
	public int extraIndividualTowers; //Field offset: 0x30
	public int extraTotalTowers; //Field offset: 0x34

	public CtTowerLimitsModModel(string name, int extraIndividualTowers, int extraTotalTowers) { }

	public override void ApplyModification(DailyChallengeModel dcm) { }

	public virtual Model Clone() { }

	public override void RemoveModification(DailyChallengeModel dcm) { }

}

