namespace Assets.Scripts.Models.Map;

public class CamoDetectAreaBuffModel : AreaBuffModel
{
	public class AreaTowerCamoDetectMutator : BehaviorMutator
	{

		public AreaTowerCamoDetectMutator(bool isUnique, string mutatorId, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private AreaTowerCamoDetectMutator mutator; //Field offset: 0x50

	public CamoDetectAreaBuffModel(string name, string mutatorId, int priority, BuffIndicatorModel buffIndicator, TowerSet[] filterInTowerSets) { }

	public virtual Model Clone() { }

	public virtual BehaviorMutator GetMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

