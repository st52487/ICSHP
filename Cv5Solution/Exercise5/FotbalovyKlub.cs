using System.ComponentModel;

namespace Exercise5
{
    public enum FotbalovyKlub {
        None,
        [Description("FC Porto")] FCPorto,
        Arsenal,
        [Description("Real Madrid")] RealMadrid,
        Chelsea,
        Barcelona
    }
}
