namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(AddBehaviorsArtifact), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddProjectileBehaviorsArtifactModel : AddBehaviorArtifactModel<ProjectileBehaviorModel, ProjectileModel>
{

	protected AddProjectileBehaviorsArtifactModel(string name, String[] addOnlyIfScriptsExists, String[] dontAddIfScriptsExists, String[] replaceScriptNames, String[] replaceScriptIds, String[] towerTypes, bool inverseTowerTypes, TowerSet[] towerSets, bool inverseSets, Int32[] tiers, bool tiersMustBeEqual, bool inverseTiers, bool ignoreSubTowers, bool ignorePowerTowers) { }

	public virtual Model Clone() { }

}

