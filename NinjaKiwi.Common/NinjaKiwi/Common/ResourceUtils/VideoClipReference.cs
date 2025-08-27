namespace NinjaKiwi.Common.ResourceUtils;

public struct VideoClipReference : IAssetReference, IAssetReference<VideoClip>, IEquatable<VideoClipReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(VideoClip)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public VideoClipReference(string guid) { }

	public override bool Equals(VideoClipReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(VideoClipReference lhs, VideoClipReference rhs) { }

	public static bool op_Inequality(VideoClipReference lhs, VideoClipReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

