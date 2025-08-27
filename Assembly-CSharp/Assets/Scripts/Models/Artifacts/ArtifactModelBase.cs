namespace Assets.Scripts.Models.Artifacts;

public abstract class ArtifactModelBase : Model
{
	private static readonly String[] tierKeys; //Field offset: 0x0
	public int tier; //Field offset: 0x30
	public string baseId; //Field offset: 0x38
	[LocalizedText]
	[SerializeField]
	protected string nameLocKey; //Field offset: 0x40
	[LocalizedText]
	[SerializeField]
	protected string descriptionLocKey; //Field offset: 0x48
	public String[] descriptionParams; //Field offset: 0x50
	[ExtendedDrawer]
	public ModModel monkeyKnowledgeModModels; //Field offset: 0x58
	public bool isBossArtifact; //Field offset: 0x60
	public SpriteReference icon; //Field offset: 0x68
	public string rarityFrameType; //Field offset: 0x70
	public int merchantCostMultiplier; //Field offset: 0x78
	public bool isQuestArtifact; //Field offset: 0x7C

	public string ArtifactName
	{
		 get { } //Length: 7
	}

	public int ArtifactPower
	{
		 get { } //Length: 102
	}

	public bool IsBoost
	{
		 get { } //Length: 125
	}

	private static ArtifactModelBase() { }

	protected ArtifactModelBase(string name, int tier, string baseId, string nameLocKey, string descriptionLocKey, String[] descriptionParams, SpriteReference icon, string rarityFrameType, bool isBossArtifact, bool isQuestArtifact, int merchantCostMultiplier) { }

	public string get_ArtifactName() { }

	public int get_ArtifactPower() { }

	public bool get_IsBoost() { }

	public abstract Model[] GetArtifactBehaviorModels() { }

	public string GetDescription(ILocProvider locProvider) { }

	public int GetMerchantCost() { }

	public string GetTitle(ILocProvider locProvider) { }

}

