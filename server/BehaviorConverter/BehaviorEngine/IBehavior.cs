using System.Collections.Generic;

namespace BehaviorConverter.BehaviorEngine
{
    public interface IBehavior
    {
        string ClassName { get; }

        int ArgumentsCount { get; }
        int AdditionalArgumentsCount { get; }

        int UsedArgumentsCount { get; }
        int UsedAdditionalArgumentsCount { get; }

        IDictionary<string, int> ArgumentNames { get; }
        IDictionary<string, int> ArgumentValues { get; }

        IArgumentList ArgumentDict { get; }
    }
}
