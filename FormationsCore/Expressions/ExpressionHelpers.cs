using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Formations.Engine.Core
{
    /// <summary>
    /// A helper class for lambda expressions
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// Compiles an expression and gets the functions return value
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> returned</typeparam>
        /// <param name="lambda">The <see cref="LambdaExpression"/> to compile and invoke</param>
        /// <returns>The compiled expression's value</returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda)
        {
            return lambda.Compile().Invoke();
        }

        /// <summary>
        /// Converts a lambda expression such as '()=>some.Property' to 'some.Property'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lambda"></param>
        /// <param name="value"></param>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
        {
            // Check that the expression is not null
            if (!((lambda as LambdaExpression).Body is MemberExpression expression)) return;

            // Get the property info of the passed expression
            var propertyInfo = (PropertyInfo)expression.Member;

            // Compile and invoke the expression
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            // Set the property value.
            propertyInfo?.SetValue(target, value);
        }
    }
}
