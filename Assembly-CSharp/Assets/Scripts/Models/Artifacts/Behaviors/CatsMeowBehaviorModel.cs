namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(CatsMeowBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CatsMeowBehaviorModel : ItemArtifactBehaviorModel
{
	public int maxLives; //Field offset: 0x30
	public int livesRecovery; //Field offset: 0x34

	public CatsMeowBehaviorModel(string name, int maxLives, int livesRecovery) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

