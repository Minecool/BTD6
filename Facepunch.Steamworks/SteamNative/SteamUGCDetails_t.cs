namespace SteamNative;

internal struct SteamUGCDetails_t
{
	internal ulong PublishedFileId; //Field offset: 0x0
	internal Result Result; //Field offset: 0x8
	internal WorkshopFileType FileType; //Field offset: 0xC
	internal uint CreatorAppID; //Field offset: 0x10
	internal uint ConsumerAppID; //Field offset: 0x14
	internal string Title; //Field offset: 0x18
	internal string Description; //Field offset: 0x20
	internal ulong SteamIDOwner; //Field offset: 0x28
	internal uint TimeCreated; //Field offset: 0x30
	internal uint TimeUpdated; //Field offset: 0x34
	internal uint TimeAddedToUserList; //Field offset: 0x38
	internal RemoteStoragePublishedFileVisibility Visibility; //Field offset: 0x3C
	internal bool Banned; //Field offset: 0x40
	internal bool AcceptedForUse; //Field offset: 0x41
	internal bool TagsTruncated; //Field offset: 0x42
	internal string Tags; //Field offset: 0x48
	internal ulong File; //Field offset: 0x50
	internal ulong PreviewFile; //Field offset: 0x58
	internal string PchFileName; //Field offset: 0x60
	internal int FileSize; //Field offset: 0x68
	internal int PreviewFileSize; //Field offset: 0x6C
	internal string URL; //Field offset: 0x70
	internal uint VotesUp; //Field offset: 0x78
	internal uint VotesDown; //Field offset: 0x7C
	internal float Score; //Field offset: 0x80
	internal uint NumChildren; //Field offset: 0x84

}

