

namespace Refleksja
{
    public static class ObjectHelper
    {
        public static void ChangeValue(object obj, string valueName, object newValue)
        {
            Type type = obj.GetType();

            var propertyToUpdate = type.GetProperty(valueName);
            
            if (propertyToUpdate != null)
            {
                var propValue = propertyToUpdate.GetValue(obj);

                if (propValue != null && (propValue.GetType().IsPrimitive || propValue.GetType() == typeof(string)))
                {
                    propertyToUpdate.SetValue(obj, newValue);
                }
                
            }
            else
            {
                var propsInfo = type.GetProperties();

                foreach (var propInfo in propsInfo)
                {
                    var value = propInfo.GetValue(obj);
                    if (value != null && value.GetType().IsClass && value.GetType() != typeof(string))
                    {
                        ChangeValue(value, valueName, newValue);
                    }
                }
            }


        }

        public static void Display(object obj)
        {
            Type type = obj.GetType();

            var propertyInfos = type.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                var propertyName = propertyInfo.Name;

                var propertyValue = propertyInfo.GetValue(obj);

                if (propertyValue != null && (propertyValue.GetType().IsPrimitive || propertyValue.GetType() == typeof(string) || propertyValue.GetType().IsEnum))
                {
                    Console.WriteLine($"{propertyName}: {propertyValue}");
                }
                else if(propertyValue != null)
                {
                    Console.WriteLine($"{propertyName}:");
                    Display(propertyValue);
                }
                else
                {
                    Console.WriteLine($"{propertyName}: ?");
                }
                
            }
        }
    }
}
