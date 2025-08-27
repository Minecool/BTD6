namespace Assets.Scripts.Unity.Utils;

public class DefaultValueContractResolver : DefaultContractResolver
{
	private readonly Dictionary<Type, DefaultValueHandling> _overrides; //Field offset: 0x38

	public DefaultValueContractResolver(Dictionary<Type, DefaultValueHandling> overrides) { }

	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

}

