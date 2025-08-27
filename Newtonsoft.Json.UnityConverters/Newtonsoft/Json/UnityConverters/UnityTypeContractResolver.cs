namespace Newtonsoft.Json.UnityConverters;

public class UnityTypeContractResolver : DefaultContractResolver
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Type objectType; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		[NullableContext(1)]
		internal object <CreateObjectContract>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public List<MemberInfo> alreadyAdded; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <GetMissingMembers>b__0(MemberInfo o) { }

	}


	public UnityTypeContractResolver() { }

	private static bool CanReadMemberWithSerializeField(MemberInfo member) { }

	private static bool CanWriteMemberWithSerializeField(MemberInfo member) { }

	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	private static IEnumerable<MemberInfo> GetMissingMembers(Type type, List<MemberInfo> alreadyAdded) { }

	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

}

