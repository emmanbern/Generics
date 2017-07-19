using Interfaces.DAL;
using Interfaces.Service;

namespace Services.BaseServices
{
    public class BaseService : IBaseService
    {
        protected IUnitOfWork _unitOfWork;

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
