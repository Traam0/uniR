using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using UniR.Domain.Common.Attributes;

namespace UniR.Domain.Common.Abstract;

public abstract class AuditableEntity : Entity
{
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }


    public bool TryGetSecurityTag(out string? value)
    {
        //TODO Impl After adding Security Tag Prop Attribute
        Span<PropertyInfo> properties = CollectionsMarshal.AsSpan(
            GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.IsDefined(typeof(AuditProperty))).ToList()
        );
        
        if (properties.IsEmpty)
        {
            value = null;
            return false;
        }

        StringBuilder metaDataSb = new();
        foreach (var propertyInfo in properties)
        {
            string propertyName = propertyInfo.GetCustomAttribute<AuditProperty>()?.AltName ?? propertyInfo.Name;
            metaDataSb.Append(propertyName)
                .Append(">>")
                .Append(propertyInfo.GetValue(this))
                .AppendLine(">>>");
        }
        byte[] bytes = Encoding.UTF8.GetBytes(metaDataSb.ToString());
        metaDataSb.Clear();
        
        for (var i = 0; i < bytes.Length; i++)
        {
            byte @byte = bytes[i];
            int n, n1, n2;
            n = @byte;
            n1 = n & 15;
            n2 = (n >> 4) & 15;
            if (n2 > 9) metaDataSb.Append(n2 - 10 + 'A');
            else metaDataSb.Append(n2);
            if (n1 > 9) metaDataSb.Append(n1 - 10 + 'A');
            else metaDataSb.Append(n1);
            if ((i + 1) != bytes.Length && (i + 1) % 2 == 0) metaDataSb.Append('-');
        }
        
        value = metaDataSb.ToString();
        return true;
    }
}