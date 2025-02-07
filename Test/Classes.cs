using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGlobals;

namespace Test
{
    [MessagePackObject(AllowPrivate = true, SuppressSourceGeneration = true)]
    public class ExternalTestClass : ExternalBaseTestClass
    {
        [Key(1)]
        private int childValue;

        [IgnoreMember]
        public int ChildValue { get => childValue; set => childValue = value; }
    }

    [MessagePackObject(AllowPrivate = true, SuppressSourceGeneration = true)]
    public class ExternalTestWithoutMembersClass : ExternalBaseTestClass
    {
    }


    [MessagePackObject(AllowPrivate = true, SuppressSourceGeneration = true)]
    public class InternalTestClass : InternalBaseTestClass
    {
        [Key(1)]
        private int childValue;

        [IgnoreMember]
        public int ChildValue { get => childValue; set => childValue = value; }
    }

    [MessagePackObject(AllowPrivate = true, SuppressSourceGeneration = true)]
    public class InternalTestWithoutMembersClass : InternalBaseTestClass
    {
    }

    [MessagePackObject(AllowPrivate = true, SuppressSourceGeneration = true)]
    public class InternalBaseTestClass
    {
        [Key(0)]
        private int baseValue;

        [IgnoreMember]
        public int BaseValue { get => baseValue; set => baseValue = value; }
    }

}
