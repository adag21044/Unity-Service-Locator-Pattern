using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator 
{
    private static readonly Dictionary<System.Type, object> _services = new Dictionary<System.Type, object>();

    public static void RegisterService<T>(T service)
    {
        var type = typeof(T);
        if (_services.ContainsKey(type))
        {
            _services[type] = service;
        }
        else
        {
            _services.Add(type, service);
        }
    }

    public static T GetService<T>()
    {
        var type = typeof(T);
        if (_services.ContainsKey(type))
        {
            return (T)_services[type];
        }
        else
        {
            Debug.LogError($"Service of type {type} not found");
            return default(T);
        }
    }
}
