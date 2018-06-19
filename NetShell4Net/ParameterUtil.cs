using System;

namespace Monicais.NetShell4Net
{
    public static class ParameterUtil
    {
        public static string Required(string paramName, string value, bool quotationAround = false)
            => quotationAround ? $" {paramName}=\"{value}\"" : $" {paramName}={value}";

        public static string Required<T>(string paramName, ParameterEnum<T> value, bool quotationAround = false)
            => quotationAround ? $" {paramName}=\"{value}\"" : $" {paramName}={value.Value}";

        public static string Required<T>(string paramName, T value, bool quotationAround = false)
            => quotationAround ? $" {paramName}=\"{value}\"" : $" {paramName}={value}";

        public static string Required(string paramName, bool value, string trueValue = "yes", string falseValue = "no")
            => $" {paramName}={(value ? trueValue : falseValue)}";

        public static string Optional(string paramName, string value = null, bool quotationAround = false)
            => quotationAround ? $"{(value != null ? $" {paramName}=\"{value}\"" : "")}" : $"{(value != null ? $" {paramName}={value}" : "")}";

        public static string Optional<T>(string paramName, ParameterEnum<T> value = null, bool quotationAround = false)
            => quotationAround ? $"{(value != null ? $" {paramName}=\"{value}\"" : "")}" : $"{(value != null ? $" {paramName}={value.Value}" : "")}";

        public static string Optional<T>(string paramName, T value, bool quotationAround = false)
            => quotationAround ? $"{(value != null ? $" {paramName}=\"{value}\"" : "")}" : $"{(value != null ? $" {paramName}={value}" : "")}";

        public static string Optional(string paramName, bool? value, string trueValue = "yes", string falseValue = "no")
            => value.HasValue ? $" {paramName}={(value.Value ? trueValue : falseValue)}" : "";
    }
}
