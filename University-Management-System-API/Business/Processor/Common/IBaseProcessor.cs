using System.Collections.Generic;
using System.Threading.Tasks;

namespace University_Management_System_API.Business.Processor.Common
{
    public interface IBaseProcessor<TParam, TResult, TPK>
    {
        TResult Create(TParam param);
        List<TResult> Create(List<TParam> param);

        void Update(TPK id, TParam param);
        void Update(List<TParam> param);

        void Delete(TPK id);
        void Delete(List<TPK> idList);

        TResult Find(TPK id);
        List<TResult> Find();
        List<TResult> Find(string field, string value);
        TResult FindByCode(string code);
        TResult FindByName(string name);

        void ValidateParameters(TParam param);
        void ValidateParameters(List<TParam> param);
    }
}
