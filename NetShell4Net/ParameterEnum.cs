using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Monicais.NetShell4Net
{
    public class ParameterEnum<T> : IEquatable<ParameterEnum<T>>
    {
        public ParameterEnum(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ParameterEnum<T>);
        }

        public bool Equals(ParameterEnum<T> other)
        {
            return other != null &&
                   EqualityComparer<T>.Default.Equals(Value, other.Value);
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<T>.Default.GetHashCode(Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static bool operator ==(ParameterEnum<T> enum1, ParameterEnum<T> enum2)
        {
            return EqualityComparer<ParameterEnum<T>>.Default.Equals(enum1, enum2);
        }

        public static bool operator !=(ParameterEnum<T> enum1, ParameterEnum<T> enum2)
        {
            return !(enum1 == enum2);
        }
    }
}