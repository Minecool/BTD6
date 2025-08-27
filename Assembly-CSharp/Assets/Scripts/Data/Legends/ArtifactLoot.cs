namespace Assets.Scripts.Data.Legends;

public class ArtifactLoot : RogueLoot
{
	public string artifactName; //Field offset: 0x10
	public int tier; //Field offset: 0x18
	public string baseId; //Field offset: 0x20
	public RogueLootType lootType; //Field offset: 0x28
	public bool startingArtifact; //Field offset: 0x2C

	public bool IsMMToken
	{
		 get { } //Length: 61
	}

	public bool IsToken
	{
		 get { } //Length: 61
	}

	public bool IsXPToken
	{
		 get { } //Length: 61
	}

	public ArtifactLoot() { }

	public bool get_IsMMToken() { }

	public bool get_IsToken() { }

	public bool get_IsXPToken() { }

}

