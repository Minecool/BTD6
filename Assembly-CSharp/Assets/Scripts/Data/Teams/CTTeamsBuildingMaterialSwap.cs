namespace Assets.Scripts.Data.Teams;

public class CTTeamsBuildingMaterialSwap : AssetChangeItem
{
	public string trophyStoreId; //Field offset: 0x20
	[SerializeField]
	private MaterialReference defaultMaterial; //Field offset: 0x28
	[SerializeField]
	private MaterialReference material1; //Field offset: 0x30
	[SerializeField]
	private MaterialReference material2; //Field offset: 0x38
	[SerializeField]
	private MaterialReference material3; //Field offset: 0x40
	[SerializeField]
	private MaterialReference material4; //Field offset: 0x48
	[SerializeField]
	private MaterialReference material5; //Field offset: 0x50
	[SerializeField]
	private MaterialReference material6; //Field offset: 0x58

	public MaterialReference DefaultMaterial
	{
		 get { } //Length: 5
	}

	public CTTeamsBuildingMaterialSwap() { }

	public MaterialReference get_DefaultMaterial() { }

	public MaterialReference GetMaterialForTeamColourType(string teamColour) { }

}

