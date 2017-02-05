using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Client.WPF.Infrastructure
{
    public static class PropertySupport
    {
        // Methods
        public static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression) {
            if (propertyExpression == null) {
                throw new ArgumentNullException("propertyExpression");
            }
            MemberExpression body = propertyExpression.Body as MemberExpression;
            if (body == null) {
                throw new ArgumentException("propertyExpression");
            }
            PropertyInfo member = body.Member as PropertyInfo;
            if (member == null) {
                throw new ArgumentException("propertyExpression");
            }
            if (member.GetGetMethod(true).IsStatic) {
                throw new ArgumentException("propertyExpression");
            }
            return body.Member.Name;
        }
    }
}
