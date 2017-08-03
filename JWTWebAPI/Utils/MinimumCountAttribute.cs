using System;
using System.ComponentModel.DataAnnotations;

namespace JWTWebAPI.Utils
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class MinimumCountAttribute : ValidationAttribute
    {
        private readonly int _minCount;
        private readonly bool _allowEmptyStringValues;
        private readonly bool _required;
        private const string _defaultError = "'{0}' must have at least {1} item.";

        public MinimumCountAttribute() : this(1)
        {

        }

        public MinimumCountAttribute(int minCount, bool required = true, bool allowEmptyStringValues = false) : base(_defaultError)
        {
            _minCount = minCount;
            _required = required;
            _allowEmptyStringValues = allowEmptyStringValues;
        }
    }
}
