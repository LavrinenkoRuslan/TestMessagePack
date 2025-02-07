using MessagePack;
using MessagePack.Resolvers;
using Test;

MessagePackSerializerOptions GetResolver()
{
    var resolver = CompositeResolver.Create(
        NativeDecimalResolver.Instance,
        NativeGuidResolver.Instance,
        NativeDateTimeResolver.Instance,
        TypelessObjectResolver.Instance,
        StandardResolver.Instance
    );
    return MessagePackSerializerOptions.Standard.WithResolver(resolver).WithOmitAssemblyVersion(true);
}


try
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(MessagePackSerializer.SerializeToJson(new InternalTestWithoutMembersClass() { BaseValue = 1}, GetResolver()));
    //MessagePackSerializer.Serialize(new InternalTestWithoutMembersClass() { BaseValue = 1}, GetResolver());
    Console.WriteLine("InternalTestWithoutMembersClass Ok");
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message);
    if (e.InnerException != null)
        Console.WriteLine(e.InnerException.Message);
}

try
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(MessagePackSerializer.SerializeToJson(new InternalTestClass() { BaseValue = 1, ChildValue = 2 }, GetResolver()));
    //MessagePackSerializer.Serialize(new InternalTestClass() { BaseValue = 1, ChildValue = 2 }, GetResolver());
    Console.WriteLine("InternalTestClass Ok");
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message);
    if (e.InnerException != null)
        Console.WriteLine(e.InnerException.Message);
}



try
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(MessagePackSerializer.SerializeToJson(new ExternalTestClass() { BaseValue = 1, ChildValue = 2 }, GetResolver()));
    //MessagePackSerializer.Serialize(new ExternalTestClass() { BaseValue = 1, ChildValue = 2 }, GetResolver());
    Console.WriteLine("ExternalTestClass Ok");
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message);
    if (e.InnerException != null)
        Console.WriteLine(e.InnerException.Message);
}

try
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(MessagePackSerializer.SerializeToJson(new ExternalTestWithoutMembersClass() { BaseValue = 1 }, GetResolver()));
    //MessagePackSerializer.Serialize(new ExternalTestWithoutMembersClass() { BaseValue = 1 }, GetResolver());
    Console.WriteLine("ExternalTestWithoutMembersClass Ok");
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message);
    if (e.InnerException != null)
        Console.WriteLine(e.InnerException.Message);
}



Console.ReadLine();

