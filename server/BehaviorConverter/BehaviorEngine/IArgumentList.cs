using System;
using System.Collections.Generic;

namespace BehaviorConverter.BehaviorEngine
{
    public interface IArgumentList
    {
        //<parameterName, <index, <defaultValue, parameterType>>>
        IDictionary<string, KeyValuePair<int, KeyValuePair<object, Type>>> NameToParameter { get; } 
    }
}
