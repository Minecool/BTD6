namespace NinjaKiwi.GUTS.Models.CardPacks;

public class CardPacksSettings
{
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x10
	public Int32[] RareChances; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<String, CardPackSettings> <Packs>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Dictionary<BcsCardRarity, Int32> <CardPackContents>k__BackingField; //Field offset: 0x28

	public Dictionary<BcsCardRarity, Int32> CardPackContents
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, CardPackSettings> Packs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public CardPacksSettings() { }

	[CompilerGenerated]
	public Dictionary<BcsCardRarity, Int32> get_CardPackContents() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	public Dictionary<String, CardPackSettings> get_Packs() { }

	[CompilerGenerated]
	public void set_CardPackContents(Dictionary<BcsCardRarity, Int32> value) { }

	[CompilerGenerated]
	public void set_IsEnabled(bool value) { }

	[CompilerGenerated]
	public void set_Packs(Dictionary<String, CardPackSettings> value) { }

}

