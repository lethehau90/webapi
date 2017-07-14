using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IFeedbackService : IBaseInterface<Feedback>
    {
        //Feedback Create(Feedback feedback);

        //void Save();
    }

    public class FeedbackService : IFeedbackService
    {
        private IFeedbackRepository _feedbackRepository;
        private IUnitOfWork _unitOfWork;

        public FeedbackService(IFeedbackRepository feedbackRepository, IUnitOfWork unitOfWork)
        {
            _feedbackRepository = feedbackRepository;
            _unitOfWork = unitOfWork;
        }

        public Feedback Create(Feedback feedback)
        {
            return _feedbackRepository.Add(feedback);
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Feedback> GetAll()
        {
            throw new NotImplementedException();
        }

        public Feedback GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Feedback t)
        {
            throw new NotImplementedException();
        }
    }
}