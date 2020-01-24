using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace University_Management_System_API.Business.Convertor.Common
{
    public abstract class BaseResultConverter<TEntity, TResult> : IBaseResultConverter<TEntity, TResult>
    {
        /// <summary>
        /// Maps the entity's properties with the corresponding param properties.
        /// if the param's property has the track attribute it will map the property 
        /// to a destination property(from the attribute) in the entity.m
        /// </summary>
        /// <param name="param">Param</param>
        /// <param name="result">Result</param>
        /// <returns>Mapped result</returns>
        public TResult ConvertStandart(TEntity param, TResult result)
        {
            Dictionary<string, PropertyInfo> paramProp = param.GetType().GetProperties()
             .ToDictionary(x => x.Name, x => x);

            Dictionary<string, PropertyInfo> resultProp = result.GetType().GetProperties()
                .ToDictionary(x => x.Name, x => x);

            foreach (var paramItem in paramProp)
            {
                if (resultProp.ContainsKey(paramItem.Key))
                {
                    result.GetType().GetProperty(paramItem.Key).SetValue(
                        result, paramItem.Value.GetValue(param));
                }
            }

            return result;
        }

        /// <summary>
        /// Sets the result's specific properties using the metadata for the property
		/// from the related param's property.
        /// </summary>
        /// <param name="param">Param</param>
        /// <param name="result">Result</param>
        public abstract void ConvertSpecific(TEntity param, TResult result);

        public TResult Convert(TEntity entity)
        {
            TResult result = ConvertStandart(entity, GetResult());

            ConvertSpecific(entity, result);

            return result;
        }

        /// <summary>
        /// returns an Instance to an object
        /// </summary>
        /// <returns>Result Object</returns>
        public abstract TResult GetResult();
    }
}
