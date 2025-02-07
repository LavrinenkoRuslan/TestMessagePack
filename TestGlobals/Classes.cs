using MessagePack;

namespace TestGlobals
{
    [MessagePackObject(AllowPrivate = true, SuppressSourceGeneration = true)]
    public class ExternalBaseTestClass
    {
        [Key(0)]
        private int baseValue;

        [IgnoreMember]
        public int BaseValue { get => baseValue; set => baseValue = value; }
    }
}
