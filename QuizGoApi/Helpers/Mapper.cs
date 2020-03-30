using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizGoApi.Dtos;
using QuizGoApi.Models;

namespace QuizGoApi.Helpers
{
    public class Mapper
    {
        public static IEnumerable<QuestionsToReturnDto> Map(IList<Question> questions)
        {
            IList<QuestionsToReturnDto> questionsToReturnDto = new List<QuestionsToReturnDto>();
            int id = 1;
            foreach (var question in questions)
            {
                questionsToReturnDto.Add(question.Map(id));
                id++;
            }

            return questionsToReturnDto;
        }

        public static UserToReturnDto MapUserToReturn(User userFromRepo)
        {
            return new UserToReturnDto()
            {
                Email = userFromRepo.Email,
                Id = userFromRepo.Id,
                Username = userFromRepo.UserName,
                Gender = userFromRepo.Gender
            };
        }
    }
}
