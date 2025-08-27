namespace Assets.Scripts.Data.Behaviors;

public interface IArtifactIncluder
{

	public IEnumerable<String> GetArtifactIdsToInclude() { }

	public IEnumerable<Model> GetArtifactModelsToInclude() { }

}

