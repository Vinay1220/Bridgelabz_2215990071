using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class InjectAttribute : Attribute
{
}

public class DIContainer
{
    private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

    public void Register<T>(T instance)
    {
        _services[typeof(T)] = instance;
    }

    public T Resolve<T>()
    {
        Type type = typeof(T);
        object instance = Activator.CreateInstance(type);

        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (var field in fields.Where(f => f.GetCustomAttribute<InjectAttribute>() != null))
        {
            var fieldValue = _services[field.FieldType];
            field.SetValue(instance, fieldValue);
        }

        foreach (var property in properties.Where(p => p.GetCustomAttribute<InjectAttribute>() != null))
        {
            var propertyValue = _services[property.PropertyType];
            property.SetValue(instance, propertyValue);
        }

        return (T)instance;
    }
}

public interface IMessageService
{
    void SendMessage(string message);
}

public class MessageService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Message sent: " + message);
    }
}

public class NotificationService
{
    [Inject]
    public IMessageService MessageService { get; set; }

    public void Notify(string message)
    {
        MessageService.SendMessage(message);
    }
}

class Program
{
    static void Main()
    {
        DIContainer container = new DIContainer();

        container.Register<IMessageService>(new MessageService());

        NotificationService notificationService = container.Resolve<NotificationService>();
        notificationService.Notify("Hello Dependency Injection!");
    }
}