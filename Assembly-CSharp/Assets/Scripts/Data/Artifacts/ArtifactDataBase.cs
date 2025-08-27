namespace Assets.Scripts.Data.Artifacts;

public abstract class ArtifactDataBase : ScriptableObject
{

	protected ArtifactDataBase() { }

	public abstract Model ArtifactModel() { }

}

