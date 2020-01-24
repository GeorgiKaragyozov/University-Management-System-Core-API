namespace University_Management_System_API.Business.Convertor.Common
{
    public interface IBaseResultConverter<TEntity, TResult>
    {
        TResult ConvertStandart(TEntity param, TResult result);

        void ConvertSpecific(TEntity param, TResult result);

        TResult Convert(TEntity param);
    }
}
