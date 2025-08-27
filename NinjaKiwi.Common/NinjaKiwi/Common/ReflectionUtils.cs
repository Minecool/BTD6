namespace NinjaKiwi.Common;

public static class ReflectionUtils
{

	private static object reflect_call(T o, string methodName, Object[] args) { }

	private static object reflect_call_static(string methodName, Type[] types, Object[] args) { }

	private static object reflect_property_get(T o, string propertyName, BindingFlags bindingFlags = 36) { }

	private static void reflect_property_set(T o, string propertyName, object value, BindingFlags bindingFlags = 36) { }

	private static void reflect_set(T o, string fieldName, object value, BindingFlags bindingFlags = 36) { }

}

