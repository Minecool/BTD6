namespace NinjaKiwi.Common.ResourceUtils;

public struct AudioSourceReference : IAssetReference, IAssetReference<AudioSource>, IEquatable<AudioSourceReference>
{
	[AssetReference(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AudioSource)}])]
	[SerializeField]
	private string guidRef; //Field offset: 0x0

	public override string AssetGUID
	{
		 get { } //Length: 4
	}

	public AudioSourceReference(string guid) { }

	public override bool Equals(AudioSourceReference rhs) { }

	public virtual bool Equals(object obj) { }

	public override string get_AssetGUID() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(AudioSourceReference lhs, AudioSourceReference rhs) { }

	public static bool op_Inequality(AudioSourceReference lhs, AudioSourceReference rhs) { }

	public override bool RuntimeKeyIsValid() { }

	public virtual string ToString() { }

}

