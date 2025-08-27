namespace Assets.Scripts.Models.Profile;

public class ContentTypeSaveData
{
	public List<String> playedIds; //Field offset: 0x10
	public List<String> favoriteIds; //Field offset: 0x18
	public List<String> upvotedIds; //Field offset: 0x20
	public List<String> wonIds; //Field offset: 0x28
	public List<String> lostIds; //Field offset: 0x30
	public List<String> created; //Field offset: 0x38
	public List<BaseSaveDataModel> saveData; //Field offset: 0x40
	public List<String> reportedIds; //Field offset: 0x48
	public List<String> curatedIds; //Field offset: 0x50
	public List<String> seenFeaturedIds; //Field offset: 0x58
	public Nullable<Int32> curationCount; //Field offset: 0x60
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime lastSubmissionTime; //Field offset: 0x68

	public ContentTypeSaveData() { }

	public bool HasCurated(string id) { }

	public bool HasReported(string id) { }

	public void SetCurated(string id, int maxSize) { }

	public void SetReported(string id, int maxSize) { }

}

